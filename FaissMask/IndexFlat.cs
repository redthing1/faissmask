using FaissMask.Internal;

namespace FaissMask
{
    public class IndexFlat : Index
    {
        public static IndexFlat Read(string filename)
        {
            var handle = IndexSafeHandle.Read(filename, ptr => new IndexFlatSafeHandle(ptr));
            return new IndexFlat(handle);
        }
        
        public void Write(string filename) {
            Handle.Write(filename);
        }
        
        internal IndexFlat(IndexFlatSafeHandle handle) : base(handle) { }
        public IndexFlat() : this(0, MetricType.MetricL2)
        {
        }
        public IndexFlat(long dimension) : this(dimension, MetricType.MetricL2)
        {
        }
        public IndexFlat(long dimension, MetricType metric) : base(IndexFlatSafeHandle.New(dimension, metric))
        {
        }
        
        private IndexFlat(object handle) : base(handle) {}
    }
}