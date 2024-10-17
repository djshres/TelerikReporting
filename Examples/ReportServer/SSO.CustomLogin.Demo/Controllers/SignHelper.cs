using System;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Telerik.ReportServer.HttpClient;

namespace CustomLoginApp.Controllers
{
    static class SignHelper
    {
        /// <summary>
        /// An example method demonstrating how to obtain a certificate from a store and use it to sign data bytes.
        /// </summary>
        /// <param name="data">CustomLoginData instance</param>
        /// <param name="certificateCommonName">Valid name from the local certificate store</param>
        public static void Sign(CustomLoginData data, string certificateCommonName)
        {
            var certificate = GetCertificate(certificateCommonName);
            //In an exception is thrown on the line below, please make sure the certificate has proper permissions set.
            //See https://stackoverflow.com/questions/45042108/privatekey-threw-an-exception-of-type-system-security-cryptography-cryptographic
            using (var csp = certificate.GetRSAPrivateKey())
            {
                //The sample implementation uses SHA1 hash algorithm.
                using (var hashAlgorithm = new SHA1Managed())
                {
                    byte[] hash = hashAlgorithm.ComputeHash(data.GetDataForSigning());
                    data.Signature = csp.SignHash(hash, HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);
                }
            }

            Verify(data, certificateCommonName);
        }

        /// <summary>
        /// An example method demonstrating how to verify signed data with a provided certificate
        /// </summary>
        /// <param name="data">CustomLoginData instance</param>
        /// <param name="certificateCommonName">Valid name from the local certificate store</param>
        public static void Verify(CustomLoginData data, string certificateCommonName)
        {
            try
            {
                var certificate = GetCertificate(certificateCommonName);

                using (var csp = (RSACryptoServiceProvider)certificate.PublicKey.Key)
                using (var hashAlgorithm = new SHA1Managed())
                {
                    var bytes = data.GetDataForSigning();
                    byte[] hash = hashAlgorithm.ComputeHash(bytes);

                    var oid = CryptoConfig.MapNameToOID("SHA1");
                    var isOK = csp.VerifyHash(hash, oid, data.Signature);
                    System.Diagnostics.Debug.WriteLine(isOK);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }

        /// <summary>
        /// Gets a certificate from the store by the specified common name. Throws a NullReferenceException if the certificate is not found.
        /// </summary>
        /// <param name="certificateCommonName">Valid name from the local certificate store</param>
        /// <returns>X509Certificate2 instance</returns>
        static X509Certificate2 GetCertificate(string certificateCommonName)
        {
            var personalStore = new X509Store(StoreName.My, StoreLocation.LocalMachine);
            personalStore.Open(OpenFlags.ReadOnly);

            var certSubject = "CN=" + certificateCommonName;
            var certificate = personalStore.Certificates
                                .OfType<X509Certificate2>()
                                .FirstOrDefault(c => c.Subject.Contains(certSubject));

            if (null == certificate)
            {
                throw new NullReferenceException(string.Format("A certificate with subject \"{0}\" was not found in the certificate store.", certSubject));
            }

            return certificate;
        }
    }
}