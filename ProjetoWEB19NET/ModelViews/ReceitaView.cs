using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWEB19NET.ModelViews
{
    /// <summary>
    /// Receita view model.
    /// </summary>
    public class ReceitaView
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Titulo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Ingredientes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ModoPreparo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Foto { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Tags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IdCategoria { get; set; }
    }
}
