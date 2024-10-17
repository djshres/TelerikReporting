using System.Collections.Generic;


namespace SpeakerObjects
{
    public class Speakers : List<Speaker>
    {
        public Speakers()
        {
            this.Add(new Speaker(1, "Allysa Nicol", "Progress", "Developer Advocate", "https://www.telerik.com/sfimages/default-source/reporting/allysa.png",
                                       "Alyssa is an Angular Developer Advocate & GDE. Her two degrees (Web Design & Development and Psychology) feed her speaking career. She has spoken at over 30 conferences internationally.",
                                       "Angular"));

            this.Add(new Speaker(2, "John Adams", "Chef", "Software Engineer", "https://www.telerik.com/sfimages/default-source/reporting/john.png",
                                   "John is a Principal Software Engineer at Progress Chef with more than 12 years of experience. He holds a master degree in Software Technologies.",
                                   "Blazor"));

            this.Add(new Speaker(3, "Sara Jameson", "Optimus IT", "Technical Support Engineer", "https://www.telerik.com/sfimages/default-source/reporting/sara.png",
                                  "Sara has been working on the Optimus IT support resources since 2017, part of the Xamarin + MAUI team. She holds a master's degree in Computer Systems and Technologies.",
                                  "Xamarin"));

            this.Add(new Speaker(4, "Emily Simpson", "TeQ Pros", "Frontend Developer", "https://www.telerik.com/sfimages/default-source/reporting/emily.png",
                                    "Emily is a React Frontend Developer. She has worked in various software development and product marketing roles. Sara has a Bachelor's in Computer Design and Master's in Computer Science.",
                                    "React"));

            this.Add(new Speaker(5, "Carl Raymond", "D Tech", "Technical Support Engineer", "https://www.telerik.com/sfimages/default-source/reporting/carl.png",
                                  "Carl is a Senior Technical Support Engineer at D Tech working with the Blazor UI components. He has experience with multiple scripting languages, but his focus is on the web development. ",
                                       "Blazor"));

            this.Add(new Speaker(6, "Thomas Hardy", "Z IT", "Product Manager", "https://www.telerik.com/sfimages/default-source/reporting/thomas.png",
                                   "Thomas is the Product Manager for the Z IT products. He has covered the entire portfolio of products offered, but mainly spent his time on the web development arena.",
                                   "React"));

            this.Add(new Speaker(7, "Antonio Moreno", "Dev Q", " QA Engineer", "https://www.telerik.com/sfimages/default-source/reporting/antonio.png",
                                    "Antonio is a QA Engineer on the DEV Q React team, where he helps build a better and more reliable product. Previously, he spent three years as a Technical Support Engineer. ",
                                    "React"));

            this.Add(new Speaker(8, "Victoria Ashworth", "V Sols", "Software Engineer", "https://www.telerik.com/sfimages/default-source/reporting/victoria.png",
                                  "Vicky is a Software Engineer with more than 5 years of experience. A Xamarin Certified Mobile Developer, she is also the founder of the company.",
                                  "Angular"));
        }
    }
}
