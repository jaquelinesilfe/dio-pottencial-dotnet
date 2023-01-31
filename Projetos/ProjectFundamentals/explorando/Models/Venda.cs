using system;
using system.collections.generic;
using system.linq;
using system.threading.tasks;

namespace Models
{
    public class Venda
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public Datetime DataVenda { get; set; }
    }
}