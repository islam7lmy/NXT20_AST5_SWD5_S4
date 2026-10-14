using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commen
{
    /// What You Can Write Inside The Namesapce?
    /// enum
    /// class
    /// struct
    /// interface
    /// delegate
    /// record


    /// What You Can Write Inside The Enum?
    /// only labels => refer to number


    /// What You Can Write Inside The Class Or Struct?
    /// variables => field [attribute]
    /// function => method
    /// constructor => special method
    /// properties
    /// events
    /// idexers => special property


    /// What You Can Write Inside The Interface?
    /// methods signature
    /// properties signature
    /// events signature
    /// indexers signature
    /// Default Implementations => C# 8.0


    /// Allowed Access Modifiers Inside The Namespace 
    /// internal [default]
    /// public


    enum rank { first, seconed, third }

    public class TypeA
    {
        /// Allowed Access Modifiers Inside The class
        ///1. private [default] 
        ///2. private protected => inhertance
        ///3. protected => inhertance
        ///4. internal
        ///5. protected internal => inhertance
        ///6. public


        rank r = rank.first;

        int x;
        internal int y;
        public int z;

        void test()
        {
            r = rank.seconed;

            x = 10;
            y = 10;
            z = 10;
        }

    }
}
