using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDidatico
{
    internal class clsConta
    {
		public int agencia;

		public int Agencia
		{
			get { return agencia; }
			set { agencia = value; }
		}

		public int numneroconta;

		public int NumeroConta
		{
			get { return NumeroConta; }
			set { NumeroConta = value; }
		}

		public double valor;

		public double Valor
		{
			get { return valor; }
			set { valor = value; }
		}

		public double saldo;

		public double Saldo
		{
			get { return saldo; }
			set { saldo = value; }
		}

	}
}
