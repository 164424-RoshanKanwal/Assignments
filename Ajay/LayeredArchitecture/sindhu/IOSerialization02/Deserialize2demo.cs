using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IOSerialization02
{
    class Deserialize2demo
    {
        [Serializable]
        class Circle : IDeserializationCallback
        {
            Double m_radius;

            // To reduce the size of the serialization stream, the field below is 
            // not serialized. This field is calculated when an object is constructed
            // or after an instance of this class is deserialized.
            [NonSerialized] public Double m_area;

            public Circle(Double radius)
            {
                m_radius = radius;
                m_area = Math.PI * radius * radius;
            }

            void IDeserializationCallback.OnDeserialization(Object sender)
            {
                // After being deserialized, initialize the m_area field 
                // using the deserialized m_radius value.
                m_area = Math.PI * m_radius * m_radius;
            }

            public override String ToString()
            {
                return String.Format("radius={0}, area={1}", m_radius, m_area);
            }
        }
    }
}
