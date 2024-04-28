namespace Data.ApiModels
{
    public class DataSetModel
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{nameof(DataSetModel)} {{{nameof(Id)}: {Id}, {nameof(Name)}: {Name}}}";
        }
    }

    public class DataSetUploadModel : DataSetModel
    {
        public string Content { get; set; }

        public override string ToString()
        {
            return $"{nameof(DataSetUploadModel)} {{{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Content)}: {Content}}}";
        }
    }
}
