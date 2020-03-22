﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SantaIsabel.DAL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="santaIsabel")]
	public partial class ConexaoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCliente(Cliente instance);
    partial void UpdateCliente(Cliente instance);
    partial void DeleteCliente(Cliente instance);
    partial void InsertUsuario(Usuario instance);
    partial void UpdateUsuario(Usuario instance);
    partial void DeleteUsuario(Usuario instance);
    partial void InsertFornecedor(Fornecedor instance);
    partial void UpdateFornecedor(Fornecedor instance);
    partial void DeleteFornecedor(Fornecedor instance);
    partial void InsertNota(Nota instance);
    partial void UpdateNota(Nota instance);
    partial void DeleteNota(Nota instance);
    partial void InsertProduto(Produto instance);
    partial void UpdateProduto(Produto instance);
    partial void DeleteProduto(Produto instance);
    partial void InsertTipo(Tipo instance);
    partial void UpdateTipo(Tipo instance);
    partial void DeleteTipo(Tipo instance);
    #endregion
		
		public ConexaoDataContext() : 
				base(global::SantaIsabel.DAL.Properties.Settings.Default.santaIsabelConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ConexaoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConexaoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConexaoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConexaoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Cliente> Clientes
		{
			get
			{
				return this.GetTable<Cliente>();
			}
		}
		
		public System.Data.Linq.Table<Usuario> Usuarios
		{
			get
			{
				return this.GetTable<Usuario>();
			}
		}
		
		public System.Data.Linq.Table<Fornecedor> Fornecedors
		{
			get
			{
				return this.GetTable<Fornecedor>();
			}
		}
		
		public System.Data.Linq.Table<Nota> Notas
		{
			get
			{
				return this.GetTable<Nota>();
			}
		}
		
		public System.Data.Linq.Table<Produto> Produtos
		{
			get
			{
				return this.GetTable<Produto>();
			}
		}
		
		public System.Data.Linq.Table<Tipo> Tipos
		{
			get
			{
				return this.GetTable<Tipo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cliente")]
	public partial class Cliente : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _codigo;
		
		private string _nome;
		
		private string _telefone;
		
		private string _email;
		
		private EntitySet<Nota> _Notas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncodigoChanging(int value);
    partial void OncodigoChanged();
    partial void OnnomeChanging(string value);
    partial void OnnomeChanged();
    partial void OntelefoneChanging(string value);
    partial void OntelefoneChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    #endregion
		
		public Cliente()
		{
			this._Notas = new EntitySet<Nota>(new Action<Nota>(this.attach_Notas), new Action<Nota>(this.detach_Notas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_cliente", Storage="_codigo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int codigo
		{
			get
			{
				return this._codigo;
			}
			set
			{
				if ((this._codigo != value))
				{
					this.OncodigoChanging(value);
					this.SendPropertyChanging();
					this._codigo = value;
					this.SendPropertyChanged("codigo");
					this.OncodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="nome_cliente", Storage="_nome", DbType="VarChar(50)")]
		public string nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if ((this._nome != value))
				{
					this.OnnomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("nome");
					this.OnnomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="telefone_cliente", Storage="_telefone", DbType="VarChar(15)")]
		public string telefone
		{
			get
			{
				return this._telefone;
			}
			set
			{
				if ((this._telefone != value))
				{
					this.OntelefoneChanging(value);
					this.SendPropertyChanging();
					this._telefone = value;
					this.SendPropertyChanged("telefone");
					this.OntelefoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(20)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cliente_Nota", Storage="_Notas", ThisKey="codigo", OtherKey="id_cliente")]
		public EntitySet<Nota> Notas
		{
			get
			{
				return this._Notas;
			}
			set
			{
				this._Notas.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Notas(Nota entity)
		{
			this.SendPropertyChanging();
			entity.Cliente = this;
		}
		
		private void detach_Notas(Nota entity)
		{
			this.SendPropertyChanging();
			entity.Cliente = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuario")]
	public partial class Usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_usuario;
		
		private string _nome_usuario;
		
		private string _senha;
		
		private string _usuario1;
		
		private System.Nullable<char> _status;
		
		private EntitySet<Nota> _Notas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_usuarioChanging(int value);
    partial void Onid_usuarioChanged();
    partial void Onnome_usuarioChanging(string value);
    partial void Onnome_usuarioChanged();
    partial void OnsenhaChanging(string value);
    partial void OnsenhaChanged();
    partial void Onusuario1Changing(string value);
    partial void Onusuario1Changed();
    partial void OnstatusChanging(System.Nullable<char> value);
    partial void OnstatusChanged();
    #endregion
		
		public Usuario()
		{
			this._Notas = new EntitySet<Nota>(new Action<Nota>(this.attach_Notas), new Action<Nota>(this.detach_Notas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_usuario", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_usuario
		{
			get
			{
				return this._id_usuario;
			}
			set
			{
				if ((this._id_usuario != value))
				{
					this.Onid_usuarioChanging(value);
					this.SendPropertyChanging();
					this._id_usuario = value;
					this.SendPropertyChanged("id_usuario");
					this.Onid_usuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nome_usuario", DbType="VarChar(50)")]
		public string nome_usuario
		{
			get
			{
				return this._nome_usuario;
			}
			set
			{
				if ((this._nome_usuario != value))
				{
					this.Onnome_usuarioChanging(value);
					this.SendPropertyChanging();
					this._nome_usuario = value;
					this.SendPropertyChanged("nome_usuario");
					this.Onnome_usuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_senha", DbType="VarChar(12)")]
		public string senha
		{
			get
			{
				return this._senha;
			}
			set
			{
				if ((this._senha != value))
				{
					this.OnsenhaChanging(value);
					this.SendPropertyChanging();
					this._senha = value;
					this.SendPropertyChanged("senha");
					this.OnsenhaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="usuario", Storage="_usuario1", DbType="VarChar(15)")]
		public string usuario1
		{
			get
			{
				return this._usuario1;
			}
			set
			{
				if ((this._usuario1 != value))
				{
					this.Onusuario1Changing(value);
					this.SendPropertyChanging();
					this._usuario1 = value;
					this.SendPropertyChanged("usuario1");
					this.Onusuario1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Char(1)")]
		public System.Nullable<char> status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Nota", Storage="_Notas", ThisKey="id_usuario", OtherKey="id_usuario")]
		public EntitySet<Nota> Notas
		{
			get
			{
				return this._Notas;
			}
			set
			{
				this._Notas.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Notas(Nota entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = this;
		}
		
		private void detach_Notas(Nota entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Fornecedor")]
	public partial class Fornecedor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_fornecedor;
		
		private string _nome_fornecedor;
		
		private string _telefone_fornecedor;
		
		private string _email_fornecedor;
		
		private EntitySet<Produto> _Produtos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_fornecedorChanging(int value);
    partial void Onid_fornecedorChanged();
    partial void Onnome_fornecedorChanging(string value);
    partial void Onnome_fornecedorChanged();
    partial void Ontelefone_fornecedorChanging(string value);
    partial void Ontelefone_fornecedorChanged();
    partial void Onemail_fornecedorChanging(string value);
    partial void Onemail_fornecedorChanged();
    #endregion
		
		public Fornecedor()
		{
			this._Produtos = new EntitySet<Produto>(new Action<Produto>(this.attach_Produtos), new Action<Produto>(this.detach_Produtos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_fornecedor", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_fornecedor
		{
			get
			{
				return this._id_fornecedor;
			}
			set
			{
				if ((this._id_fornecedor != value))
				{
					this.Onid_fornecedorChanging(value);
					this.SendPropertyChanging();
					this._id_fornecedor = value;
					this.SendPropertyChanged("id_fornecedor");
					this.Onid_fornecedorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nome_fornecedor", DbType="VarChar(50)")]
		public string nome_fornecedor
		{
			get
			{
				return this._nome_fornecedor;
			}
			set
			{
				if ((this._nome_fornecedor != value))
				{
					this.Onnome_fornecedorChanging(value);
					this.SendPropertyChanging();
					this._nome_fornecedor = value;
					this.SendPropertyChanged("nome_fornecedor");
					this.Onnome_fornecedorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefone_fornecedor", DbType="VarChar(15)")]
		public string telefone_fornecedor
		{
			get
			{
				return this._telefone_fornecedor;
			}
			set
			{
				if ((this._telefone_fornecedor != value))
				{
					this.Ontelefone_fornecedorChanging(value);
					this.SendPropertyChanging();
					this._telefone_fornecedor = value;
					this.SendPropertyChanged("telefone_fornecedor");
					this.Ontelefone_fornecedorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email_fornecedor", DbType="VarChar(20)")]
		public string email_fornecedor
		{
			get
			{
				return this._email_fornecedor;
			}
			set
			{
				if ((this._email_fornecedor != value))
				{
					this.Onemail_fornecedorChanging(value);
					this.SendPropertyChanging();
					this._email_fornecedor = value;
					this.SendPropertyChanged("email_fornecedor");
					this.Onemail_fornecedorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Fornecedor_Produto", Storage="_Produtos", ThisKey="id_fornecedor", OtherKey="id_fornecedor")]
		public EntitySet<Produto> Produtos
		{
			get
			{
				return this._Produtos;
			}
			set
			{
				this._Produtos.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Produtos(Produto entity)
		{
			this.SendPropertyChanging();
			entity.Fornecedor = this;
		}
		
		private void detach_Produtos(Produto entity)
		{
			this.SendPropertyChanging();
			entity.Fornecedor = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Nota")]
	public partial class Nota : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_nota;
		
		private System.Nullable<int> _produtos;
		
		private System.Nullable<decimal> _qtd_produtos;
		
		private System.Nullable<decimal> _valor_produtos;
		
		private System.Nullable<decimal> _desconto;
		
		private System.Nullable<decimal> _valor_total;
		
		private System.Nullable<System.DateTime> _data_emissao;
		
		private System.Nullable<int> _id_usuario;
		
		private System.Nullable<int> _id_cliente;
		
		private EntityRef<Cliente> _Cliente;
		
		private EntityRef<Usuario> _Usuario;
		
		private EntityRef<Produto> _Produto;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_notaChanging(int value);
    partial void Onid_notaChanged();
    partial void OnprodutosChanging(System.Nullable<int> value);
    partial void OnprodutosChanged();
    partial void Onqtd_produtosChanging(System.Nullable<decimal> value);
    partial void Onqtd_produtosChanged();
    partial void Onvalor_produtosChanging(System.Nullable<decimal> value);
    partial void Onvalor_produtosChanged();
    partial void OndescontoChanging(System.Nullable<decimal> value);
    partial void OndescontoChanged();
    partial void Onvalor_totalChanging(System.Nullable<decimal> value);
    partial void Onvalor_totalChanged();
    partial void Ondata_emissaoChanging(System.Nullable<System.DateTime> value);
    partial void Ondata_emissaoChanged();
    partial void Onid_usuarioChanging(System.Nullable<int> value);
    partial void Onid_usuarioChanged();
    partial void Onid_clienteChanging(System.Nullable<int> value);
    partial void Onid_clienteChanged();
    #endregion
		
		public Nota()
		{
			this._Cliente = default(EntityRef<Cliente>);
			this._Usuario = default(EntityRef<Usuario>);
			this._Produto = default(EntityRef<Produto>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_nota", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_nota
		{
			get
			{
				return this._id_nota;
			}
			set
			{
				if ((this._id_nota != value))
				{
					this.Onid_notaChanging(value);
					this.SendPropertyChanging();
					this._id_nota = value;
					this.SendPropertyChanged("id_nota");
					this.Onid_notaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_produtos", DbType="Int")]
		public System.Nullable<int> produtos
		{
			get
			{
				return this._produtos;
			}
			set
			{
				if ((this._produtos != value))
				{
					if (this._Produto.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnprodutosChanging(value);
					this.SendPropertyChanging();
					this._produtos = value;
					this.SendPropertyChanged("produtos");
					this.OnprodutosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_qtd_produtos", DbType="Decimal(4,0)")]
		public System.Nullable<decimal> qtd_produtos
		{
			get
			{
				return this._qtd_produtos;
			}
			set
			{
				if ((this._qtd_produtos != value))
				{
					this.Onqtd_produtosChanging(value);
					this.SendPropertyChanging();
					this._qtd_produtos = value;
					this.SendPropertyChanged("qtd_produtos");
					this.Onqtd_produtosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_valor_produtos", DbType="Decimal(4,2)")]
		public System.Nullable<decimal> valor_produtos
		{
			get
			{
				return this._valor_produtos;
			}
			set
			{
				if ((this._valor_produtos != value))
				{
					this.Onvalor_produtosChanging(value);
					this.SendPropertyChanging();
					this._valor_produtos = value;
					this.SendPropertyChanged("valor_produtos");
					this.Onvalor_produtosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_desconto", DbType="Decimal(4,2)")]
		public System.Nullable<decimal> desconto
		{
			get
			{
				return this._desconto;
			}
			set
			{
				if ((this._desconto != value))
				{
					this.OndescontoChanging(value);
					this.SendPropertyChanging();
					this._desconto = value;
					this.SendPropertyChanged("desconto");
					this.OndescontoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_valor_total", DbType="Decimal(4,2)")]
		public System.Nullable<decimal> valor_total
		{
			get
			{
				return this._valor_total;
			}
			set
			{
				if ((this._valor_total != value))
				{
					this.Onvalor_totalChanging(value);
					this.SendPropertyChanging();
					this._valor_total = value;
					this.SendPropertyChanged("valor_total");
					this.Onvalor_totalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data_emissao", DbType="DateTime")]
		public System.Nullable<System.DateTime> data_emissao
		{
			get
			{
				return this._data_emissao;
			}
			set
			{
				if ((this._data_emissao != value))
				{
					this.Ondata_emissaoChanging(value);
					this.SendPropertyChanging();
					this._data_emissao = value;
					this.SendPropertyChanged("data_emissao");
					this.Ondata_emissaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_usuario", DbType="Int")]
		public System.Nullable<int> id_usuario
		{
			get
			{
				return this._id_usuario;
			}
			set
			{
				if ((this._id_usuario != value))
				{
					if (this._Usuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_usuarioChanging(value);
					this.SendPropertyChanging();
					this._id_usuario = value;
					this.SendPropertyChanged("id_usuario");
					this.Onid_usuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_cliente", DbType="Int")]
		public System.Nullable<int> id_cliente
		{
			get
			{
				return this._id_cliente;
			}
			set
			{
				if ((this._id_cliente != value))
				{
					if (this._Cliente.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_clienteChanging(value);
					this.SendPropertyChanging();
					this._id_cliente = value;
					this.SendPropertyChanged("id_cliente");
					this.Onid_clienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cliente_Nota", Storage="_Cliente", ThisKey="id_cliente", OtherKey="codigo", IsForeignKey=true)]
		public Cliente Cliente
		{
			get
			{
				return this._Cliente.Entity;
			}
			set
			{
				Cliente previousValue = this._Cliente.Entity;
				if (((previousValue != value) 
							|| (this._Cliente.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Cliente.Entity = null;
						previousValue.Notas.Remove(this);
					}
					this._Cliente.Entity = value;
					if ((value != null))
					{
						value.Notas.Add(this);
						this._id_cliente = value.codigo;
					}
					else
					{
						this._id_cliente = default(Nullable<int>);
					}
					this.SendPropertyChanged("Cliente");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Nota", Storage="_Usuario", ThisKey="id_usuario", OtherKey="id_usuario", IsForeignKey=true)]
		public Usuario Usuario
		{
			get
			{
				return this._Usuario.Entity;
			}
			set
			{
				Usuario previousValue = this._Usuario.Entity;
				if (((previousValue != value) 
							|| (this._Usuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Usuario.Entity = null;
						previousValue.Notas.Remove(this);
					}
					this._Usuario.Entity = value;
					if ((value != null))
					{
						value.Notas.Add(this);
						this._id_usuario = value.id_usuario;
					}
					else
					{
						this._id_usuario = default(Nullable<int>);
					}
					this.SendPropertyChanged("Usuario");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Produto_Nota", Storage="_Produto", ThisKey="produtos", OtherKey="id_produto", IsForeignKey=true)]
		public Produto Produto
		{
			get
			{
				return this._Produto.Entity;
			}
			set
			{
				Produto previousValue = this._Produto.Entity;
				if (((previousValue != value) 
							|| (this._Produto.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Produto.Entity = null;
						previousValue.Notas.Remove(this);
					}
					this._Produto.Entity = value;
					if ((value != null))
					{
						value.Notas.Add(this);
						this._produtos = value.id_produto;
					}
					else
					{
						this._produtos = default(Nullable<int>);
					}
					this.SendPropertyChanged("Produto");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Produto")]
	public partial class Produto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_produto;
		
		private System.Nullable<int> _id_tipo;
		
		private System.Nullable<decimal> _qtd_produto;
		
		private System.Nullable<decimal> _valor_produto;
		
		private System.Nullable<int> _id_fornecedor;
		
		private EntitySet<Nota> _Notas;
		
		private EntityRef<Fornecedor> _Fornecedor;
		
		private EntityRef<Tipo> _Tipo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_produtoChanging(int value);
    partial void Onid_produtoChanged();
    partial void Onid_tipoChanging(System.Nullable<int> value);
    partial void Onid_tipoChanged();
    partial void Onqtd_produtoChanging(System.Nullable<decimal> value);
    partial void Onqtd_produtoChanged();
    partial void Onvalor_produtoChanging(System.Nullable<decimal> value);
    partial void Onvalor_produtoChanged();
    partial void Onid_fornecedorChanging(System.Nullable<int> value);
    partial void Onid_fornecedorChanged();
    #endregion
		
		public Produto()
		{
			this._Notas = new EntitySet<Nota>(new Action<Nota>(this.attach_Notas), new Action<Nota>(this.detach_Notas));
			this._Fornecedor = default(EntityRef<Fornecedor>);
			this._Tipo = default(EntityRef<Tipo>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_produto", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_produto
		{
			get
			{
				return this._id_produto;
			}
			set
			{
				if ((this._id_produto != value))
				{
					this.Onid_produtoChanging(value);
					this.SendPropertyChanging();
					this._id_produto = value;
					this.SendPropertyChanged("id_produto");
					this.Onid_produtoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_tipo", DbType="Int")]
		public System.Nullable<int> id_tipo
		{
			get
			{
				return this._id_tipo;
			}
			set
			{
				if ((this._id_tipo != value))
				{
					if (this._Tipo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_tipoChanging(value);
					this.SendPropertyChanging();
					this._id_tipo = value;
					this.SendPropertyChanged("id_tipo");
					this.Onid_tipoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_qtd_produto", DbType="Decimal(4,0)")]
		public System.Nullable<decimal> qtd_produto
		{
			get
			{
				return this._qtd_produto;
			}
			set
			{
				if ((this._qtd_produto != value))
				{
					this.Onqtd_produtoChanging(value);
					this.SendPropertyChanging();
					this._qtd_produto = value;
					this.SendPropertyChanged("qtd_produto");
					this.Onqtd_produtoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_valor_produto", DbType="Decimal(4,2)")]
		public System.Nullable<decimal> valor_produto
		{
			get
			{
				return this._valor_produto;
			}
			set
			{
				if ((this._valor_produto != value))
				{
					this.Onvalor_produtoChanging(value);
					this.SendPropertyChanging();
					this._valor_produto = value;
					this.SendPropertyChanged("valor_produto");
					this.Onvalor_produtoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_fornecedor", DbType="Int")]
		public System.Nullable<int> id_fornecedor
		{
			get
			{
				return this._id_fornecedor;
			}
			set
			{
				if ((this._id_fornecedor != value))
				{
					if (this._Fornecedor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_fornecedorChanging(value);
					this.SendPropertyChanging();
					this._id_fornecedor = value;
					this.SendPropertyChanged("id_fornecedor");
					this.Onid_fornecedorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Produto_Nota", Storage="_Notas", ThisKey="id_produto", OtherKey="produtos")]
		public EntitySet<Nota> Notas
		{
			get
			{
				return this._Notas;
			}
			set
			{
				this._Notas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Fornecedor_Produto", Storage="_Fornecedor", ThisKey="id_fornecedor", OtherKey="id_fornecedor", IsForeignKey=true)]
		public Fornecedor Fornecedor
		{
			get
			{
				return this._Fornecedor.Entity;
			}
			set
			{
				Fornecedor previousValue = this._Fornecedor.Entity;
				if (((previousValue != value) 
							|| (this._Fornecedor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Fornecedor.Entity = null;
						previousValue.Produtos.Remove(this);
					}
					this._Fornecedor.Entity = value;
					if ((value != null))
					{
						value.Produtos.Add(this);
						this._id_fornecedor = value.id_fornecedor;
					}
					else
					{
						this._id_fornecedor = default(Nullable<int>);
					}
					this.SendPropertyChanged("Fornecedor");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tipo_Produto", Storage="_Tipo", ThisKey="id_tipo", OtherKey="id_tipo", IsForeignKey=true)]
		public Tipo Tipo
		{
			get
			{
				return this._Tipo.Entity;
			}
			set
			{
				Tipo previousValue = this._Tipo.Entity;
				if (((previousValue != value) 
							|| (this._Tipo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tipo.Entity = null;
						previousValue.Produtos.Remove(this);
					}
					this._Tipo.Entity = value;
					if ((value != null))
					{
						value.Produtos.Add(this);
						this._id_tipo = value.id_tipo;
					}
					else
					{
						this._id_tipo = default(Nullable<int>);
					}
					this.SendPropertyChanged("Tipo");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Notas(Nota entity)
		{
			this.SendPropertyChanging();
			entity.Produto = this;
		}
		
		private void detach_Notas(Nota entity)
		{
			this.SendPropertyChanging();
			entity.Produto = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tipo")]
	public partial class Tipo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_tipo;
		
		private string _nome_tipo;
		
		private EntitySet<Produto> _Produtos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_tipoChanging(int value);
    partial void Onid_tipoChanged();
    partial void Onnome_tipoChanging(string value);
    partial void Onnome_tipoChanged();
    #endregion
		
		public Tipo()
		{
			this._Produtos = new EntitySet<Produto>(new Action<Produto>(this.attach_Produtos), new Action<Produto>(this.detach_Produtos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_tipo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_tipo
		{
			get
			{
				return this._id_tipo;
			}
			set
			{
				if ((this._id_tipo != value))
				{
					this.Onid_tipoChanging(value);
					this.SendPropertyChanging();
					this._id_tipo = value;
					this.SendPropertyChanged("id_tipo");
					this.Onid_tipoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nome_tipo", DbType="VarChar(25)")]
		public string nome_tipo
		{
			get
			{
				return this._nome_tipo;
			}
			set
			{
				if ((this._nome_tipo != value))
				{
					this.Onnome_tipoChanging(value);
					this.SendPropertyChanging();
					this._nome_tipo = value;
					this.SendPropertyChanged("nome_tipo");
					this.Onnome_tipoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tipo_Produto", Storage="_Produtos", ThisKey="id_tipo", OtherKey="id_tipo")]
		public EntitySet<Produto> Produtos
		{
			get
			{
				return this._Produtos;
			}
			set
			{
				this._Produtos.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Produtos(Produto entity)
		{
			this.SendPropertyChanging();
			entity.Tipo = this;
		}
		
		private void detach_Produtos(Produto entity)
		{
			this.SendPropertyChanging();
			entity.Tipo = null;
		}
	}
}
#pragma warning restore 1591
