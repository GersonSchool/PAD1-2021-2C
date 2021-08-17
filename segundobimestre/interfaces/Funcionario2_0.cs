namespace segundo_c.interfaces
{
  //Neste exemplo a classe Funcionario2_0 poderá fazer uso de duas interfaces (Caixa e Gerente)
  public class Funcionario2_0: ICaixa, IGerente
  {
    private string nome;
    private string matricula;
    private int rg;
    private double salario;
    private int cargo;
    //método construtor
    public Funcionario2_0(string n, int rg, int cg,
    double sal)
    {
      this.Nome = n;
      this.Rg = rg;
      this.Cargo = cg;
      this.Salario = sal;
    }
    //método construtor
    public Funcionario2_0(string n, string mat, int cg,
    double sal)
    {
      this.Nome = n;
      this.Matricula = mat;
      this.Cargo = cg;
      this.Salario = sal;
    }
    public string Nome { get => nome; set => nome = value; }
    public string Matricula { get => matricula; set => matricula = value; }
    public int Rg { get => rg; set => rg = value; }
    public double Salario { get => salario; set => salario = value; }
    public int Cargo { get => cargo; set => cargo = value; }

    //exibe informações do Funcionario
    // Implementação da propriedade. Observe que a interface apenas contém a assinatura do método, pois é dessa forma que define quais métodos poderão ser utilizados pelos objetos, e é necessário implementar o método na classe, dizendo o que ele faz.
    public void getInformacaoFuncao()
    {
      if (this.Cargo == ICaixa.FUNCIONARIO_CAIXA)
        System.Console.WriteLine("O caixa " + this.Nome + ", RG " + this.Rg + ", recebe R$" + this.Salario);

      if (this.Cargo == IGerente.FUNCIONARIO_GERENTE)
        System.Console.WriteLine("O gerente " + this.Nome + ", matricula " + this.Matricula + ", recebe R$" + this.Salario);
    }
  }
}