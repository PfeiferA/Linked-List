using System;

namespace LinkedList.Model
{
    /// <summary>
    /// Lists cell
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Item<T>
    {
        /// <summary>
        /// data stored in a list cell
        /// </summary>
        private T data = default(T);

        public T Data

        {
            get { return data; }
            set
            {
                if (value != null)
                    data = value;
                else
                    throw new ArgumentNullException(nameof(value));
            }
        }
        /// <summary>
        /// Next lists cell
        /// </summary>
        public Item<T> Next { get; set; } 

        public Item(T data)
        {
            Data = data;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
