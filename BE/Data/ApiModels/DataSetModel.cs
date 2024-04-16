namespace Data.ApiModels
{
    public class DataSetModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class DataSetUploadModel : DataSetModel
    {
        private string Content { get; set; }
    }
}
