namespace MusicProject.Models
{
    /// <summary>
    /// model for the producer class
    /// </summary>
    public class ProducerModel //might be redundant, meaning we could just pass a person directly to list on album
    {
        #region Basic Fields
        /// <summary>
        /// 
        /// </summary>
        private string _name;

        /// <summary>
        /// name of the producer
        /// </summary>
        public string Name => _name;

        /// <summary>
        /// 
        /// </summary>
        private PersonModel _person;

        /// <summary>
        /// 
        /// </summary>
        public PersonModel Person => _person;
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        public ProducerModel(string name)
        {
            this._name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj is ProducerModel)
            {
                var temp = (ProducerModel)obj;
                equals = _name.Equals(temp.Name);
            }
            return equals;
        }
    }
}
