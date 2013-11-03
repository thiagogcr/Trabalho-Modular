using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class Pagamento
    {
        private int _Id { get; set; }
        private string _Descricao { get; set; }
        private decimal _Valor { get; set; }
        private int _Status { get; set; }

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Descricao
        {
            get { return _Descricao; }
            set { _Descricao = value; }
        }
        public decimal Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }
        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public string StatusAbbreviation 
        {
            get {  return ConstStatus.GetDescricao(this.Status); }
        }
        
        public Pagamento(int id, string descricao, decimal valor, int Status)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.Valor = valor;
            this.Status = Status;
        }

    }
}
