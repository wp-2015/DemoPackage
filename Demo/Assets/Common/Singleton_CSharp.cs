using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public abstract class Singleton_CSharp<T> where T : class, new()
    {
        private static T m_Instance;
        private static readonly object lockHelper = new object();

        public static T Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    lock (lockHelper)
                    {
                        if (m_Instance == null)
                        {
                            m_Instance = new T();
                        }
                    }
                }
                return m_Instance;
            }
        }

        // protected Singleton_CSharp()
        // {
        //     if (m_Instance != null)
        //     {
        //         throw new InvalidOperationException("Can't create singleton instance more than once.");
        //     }
        // }
    }
}
