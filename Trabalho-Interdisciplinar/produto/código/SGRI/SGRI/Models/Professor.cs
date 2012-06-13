<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class Professor : Usuario
    {
        private List<Disciplina> disciplinas;

        private List<Disciplina> Disciplinas
        {
            get { return disciplinas; }
            set { disciplinas = value; }
        }
    }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class Professor : Usuario
    {
        private List<Disciplina> disciplinas;

        private List<Disciplina> Disciplinas
        {
            get { return disciplinas; }
            set { disciplinas = value; }
        }
    }
>>>>>>> 738a82f4e06725b886b2019a1a6c4c845a90a75a
}