namespace SpeakerObjects
{
    public class Speaker
    {
        public Speaker(int id, string name, string company, string position, string imageUrl, string biography, string daySpeaking)
        {
            this.Id = id;
            this.Name = name;
            this.Company = company;
            this.Position = position;
            this.ImageUrl = imageUrl;
            this.Biography = biography;
            this.DaySpeaking = daySpeaking;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Company { get; set; }

        public string Position { get; set; }

        public string ImageUrl { get; set; }

        public string Biography { get; set; }

        public string DaySpeaking { get; set; }
    }
}