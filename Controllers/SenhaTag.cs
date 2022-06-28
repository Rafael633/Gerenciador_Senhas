using System;
using System.Linq;
using System.Collections.Generic;
using Models;

namespace Controllers
{
    public class SenhaTagController
    {
        public static SenhaTag IncluirSenhaTag(int SenhaId, int TagId)
        {
            if (TagId != null) 
            {
                throw new Exception("É obrigatorio informar uma Tag");
            }
            
            return new SenhaTag(SenhaId, TagId);
        }
    }
}