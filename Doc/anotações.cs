//modelo fornecedor
		public int FornecedorId {get; set; }
		public string NomeVendedor { get; set; }
        public string NomeFantasia { get; set; }
		public string RazaoSocial { get; set; } 
		public string IE { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public int CidadeId { get; set; }
		public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Celular2 { get; set; }        
        public string Observacao { get; set; }
        public string DataCadastro { get; set; }
        public char Status { get; set; }
		public byte foto { get; set; }
 
 //modelo tipo de pagamento
		public int FormaPagamenoId {get; set; }
		public string Nome { get; set; }
        public string QtdParcelas { get; set; }
        public char Status { get; set; }
        