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

namespace Store.Model.Entities.dbml
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="StoreDB")]
	public partial class LinqToStoreDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertConcreteProduct(ConcreteProduct instance);
    partial void UpdateConcreteProduct(ConcreteProduct instance);
    partial void DeleteConcreteProduct(ConcreteProduct instance);
    partial void InsertDiliveryType(DiliveryType instance);
    partial void UpdateDiliveryType(DiliveryType instance);
    partial void DeleteDiliveryType(DiliveryType instance);
    partial void InsertLink_ConcreteProduct_Order(Link_ConcreteProduct_Order instance);
    partial void UpdateLink_ConcreteProduct_Order(Link_ConcreteProduct_Order instance);
    partial void DeleteLink_ConcreteProduct_Order(Link_ConcreteProduct_Order instance);
    partial void InsertOrder(Order instance);
    partial void UpdateOrder(Order instance);
    partial void DeleteOrder(Order instance);
    partial void InsertPaymentType(PaymentType instance);
    partial void UpdatePaymentType(PaymentType instance);
    partial void DeletePaymentType(PaymentType instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertProductCategory(ProductCategory instance);
    partial void UpdateProductCategory(ProductCategory instance);
    partial void DeleteProductCategory(ProductCategory instance);
    partial void InsertProductDetail(ProductDetail instance);
    partial void UpdateProductDetail(ProductDetail instance);
    partial void DeleteProductDetail(ProductDetail instance);
    #endregion
		
		public LinqToStoreDataContext() : 
				base(global::Store.Model.Properties.Settings.Default.StoreDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToStoreDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToStoreDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToStoreDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToStoreDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ConcreteProduct> ConcreteProducts
		{
			get
			{
				return this.GetTable<ConcreteProduct>();
			}
		}
		
		public System.Data.Linq.Table<DiliveryType> DiliveryTypes
		{
			get
			{
				return this.GetTable<DiliveryType>();
			}
		}
		
		public System.Data.Linq.Table<Link_ConcreteProduct_Order> Link_ConcreteProduct_Orders
		{
			get
			{
				return this.GetTable<Link_ConcreteProduct_Order>();
			}
		}
		
		public System.Data.Linq.Table<Order> Orders
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
		
		public System.Data.Linq.Table<PaymentType> PaymentTypes
		{
			get
			{
				return this.GetTable<PaymentType>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<ProductCategory> ProductCategories
		{
			get
			{
				return this.GetTable<ProductCategory>();
			}
		}
		
		public System.Data.Linq.Table<ProductDetail> ProductDetails
		{
			get
			{
				return this.GetTable<ProductDetail>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ConcreteProduct")]
	public partial class ConcreteProduct : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _FullName;
		
		private int _ProductId;
		
		private EntitySet<Link_ConcreteProduct_Order> _Link_ConcreteProduct_Orders;
		
		private EntityRef<Product> _Product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFullNameChanging(string value);
    partial void OnFullNameChanged();
    partial void OnProductIdChanging(int value);
    partial void OnProductIdChanged();
    #endregion
		
		public ConcreteProduct()
		{
			this._Link_ConcreteProduct_Orders = new EntitySet<Link_ConcreteProduct_Order>(new Action<Link_ConcreteProduct_Order>(this.attach_Link_ConcreteProduct_Orders), new Action<Link_ConcreteProduct_Order>(this.detach_Link_ConcreteProduct_Orders));
			this._Product = default(EntityRef<Product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="NVarChar(100)")]
		public string FullName
		{
			get
			{
				return this._FullName;
			}
			set
			{
				if ((this._FullName != value))
				{
					this.OnFullNameChanging(value);
					this.SendPropertyChanging();
					this._FullName = value;
					this.SendPropertyChanged("FullName");
					this.OnFullNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="Int NOT NULL")]
		public int ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ConcreteProduct_Link_ConcreteProduct_Order", Storage="_Link_ConcreteProduct_Orders", ThisKey="Id", OtherKey="ProductId")]
		public EntitySet<Link_ConcreteProduct_Order> Link_ConcreteProduct_Orders
		{
			get
			{
				return this._Link_ConcreteProduct_Orders;
			}
			set
			{
				this._Link_ConcreteProduct_Orders.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_ConcreteProduct", Storage="_Product", ThisKey="ProductId", OtherKey="Id", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.ConcreteProducts.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.ConcreteProducts.Add(this);
						this._ProductId = value.Id;
					}
					else
					{
						this._ProductId = default(int);
					}
					this.SendPropertyChanged("Product");
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
		
		private void attach_Link_ConcreteProduct_Orders(Link_ConcreteProduct_Order entity)
		{
			this.SendPropertyChanging();
			entity.ConcreteProduct = this;
		}
		
		private void detach_Link_ConcreteProduct_Orders(Link_ConcreteProduct_Order entity)
		{
			this.SendPropertyChanging();
			entity.ConcreteProduct = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DiliveryType")]
	public partial class DiliveryType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<Order> _Orders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public DiliveryType()
		{
			this._Orders = new EntitySet<Order>(new Action<Order>(this.attach_Orders), new Action<Order>(this.detach_Orders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DiliveryType_Order", Storage="_Orders", ThisKey="Id", OtherKey="DiliveryTypeId")]
		public EntitySet<Order> Orders
		{
			get
			{
				return this._Orders;
			}
			set
			{
				this._Orders.Assign(value);
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
		
		private void attach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.DiliveryType = this;
		}
		
		private void detach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.DiliveryType = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Link_ConcreteProduct_Order")]
	public partial class Link_ConcreteProduct_Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _ProductId;
		
		private int _OrderId;
		
		private EntityRef<ConcreteProduct> _ConcreteProduct;
		
		private EntityRef<Order> _Order;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnProductIdChanging(int value);
    partial void OnProductIdChanged();
    partial void OnOrderIdChanging(int value);
    partial void OnOrderIdChanged();
    #endregion
		
		public Link_ConcreteProduct_Order()
		{
			this._ConcreteProduct = default(EntityRef<ConcreteProduct>);
			this._Order = default(EntityRef<Order>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="Int NOT NULL")]
		public int ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					if (this._ConcreteProduct.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderId", DbType="Int NOT NULL")]
		public int OrderId
		{
			get
			{
				return this._OrderId;
			}
			set
			{
				if ((this._OrderId != value))
				{
					if (this._Order.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOrderIdChanging(value);
					this.SendPropertyChanging();
					this._OrderId = value;
					this.SendPropertyChanged("OrderId");
					this.OnOrderIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ConcreteProduct_Link_ConcreteProduct_Order", Storage="_ConcreteProduct", ThisKey="ProductId", OtherKey="Id", IsForeignKey=true)]
		public ConcreteProduct ConcreteProduct
		{
			get
			{
				return this._ConcreteProduct.Entity;
			}
			set
			{
				ConcreteProduct previousValue = this._ConcreteProduct.Entity;
				if (((previousValue != value) 
							|| (this._ConcreteProduct.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ConcreteProduct.Entity = null;
						previousValue.Link_ConcreteProduct_Orders.Remove(this);
					}
					this._ConcreteProduct.Entity = value;
					if ((value != null))
					{
						value.Link_ConcreteProduct_Orders.Add(this);
						this._ProductId = value.Id;
					}
					else
					{
						this._ProductId = default(int);
					}
					this.SendPropertyChanged("ConcreteProduct");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_Link_ConcreteProduct_Order", Storage="_Order", ThisKey="OrderId", OtherKey="Id", IsForeignKey=true)]
		public Order Order
		{
			get
			{
				return this._Order.Entity;
			}
			set
			{
				Order previousValue = this._Order.Entity;
				if (((previousValue != value) 
							|| (this._Order.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Order.Entity = null;
						previousValue.Link_ConcreteProduct_Orders.Remove(this);
					}
					this._Order.Entity = value;
					if ((value != null))
					{
						value.Link_ConcreteProduct_Orders.Add(this);
						this._OrderId = value.Id;
					}
					else
					{
						this._OrderId = default(int);
					}
					this.SendPropertyChanged("Order");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Order]")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _PaymentTypeId;
		
		private int _DiliveryTypeId;
		
		private EntitySet<Link_ConcreteProduct_Order> _Link_ConcreteProduct_Orders;
		
		private EntityRef<DiliveryType> _DiliveryType;
		
		private EntityRef<PaymentType> _PaymentType;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnPaymentTypeIdChanging(int value);
    partial void OnPaymentTypeIdChanged();
    partial void OnDiliveryTypeIdChanging(int value);
    partial void OnDiliveryTypeIdChanged();
    #endregion
		
		public Order()
		{
			this._Link_ConcreteProduct_Orders = new EntitySet<Link_ConcreteProduct_Order>(new Action<Link_ConcreteProduct_Order>(this.attach_Link_ConcreteProduct_Orders), new Action<Link_ConcreteProduct_Order>(this.detach_Link_ConcreteProduct_Orders));
			this._DiliveryType = default(EntityRef<DiliveryType>);
			this._PaymentType = default(EntityRef<PaymentType>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaymentTypeId", DbType="Int NOT NULL")]
		public int PaymentTypeId
		{
			get
			{
				return this._PaymentTypeId;
			}
			set
			{
				if ((this._PaymentTypeId != value))
				{
					if (this._PaymentType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPaymentTypeIdChanging(value);
					this.SendPropertyChanging();
					this._PaymentTypeId = value;
					this.SendPropertyChanged("PaymentTypeId");
					this.OnPaymentTypeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiliveryTypeId", DbType="Int NOT NULL")]
		public int DiliveryTypeId
		{
			get
			{
				return this._DiliveryTypeId;
			}
			set
			{
				if ((this._DiliveryTypeId != value))
				{
					if (this._DiliveryType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDiliveryTypeIdChanging(value);
					this.SendPropertyChanging();
					this._DiliveryTypeId = value;
					this.SendPropertyChanged("DiliveryTypeId");
					this.OnDiliveryTypeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_Link_ConcreteProduct_Order", Storage="_Link_ConcreteProduct_Orders", ThisKey="Id", OtherKey="OrderId")]
		public EntitySet<Link_ConcreteProduct_Order> Link_ConcreteProduct_Orders
		{
			get
			{
				return this._Link_ConcreteProduct_Orders;
			}
			set
			{
				this._Link_ConcreteProduct_Orders.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DiliveryType_Order", Storage="_DiliveryType", ThisKey="DiliveryTypeId", OtherKey="Id", IsForeignKey=true)]
		public DiliveryType DiliveryType
		{
			get
			{
				return this._DiliveryType.Entity;
			}
			set
			{
				DiliveryType previousValue = this._DiliveryType.Entity;
				if (((previousValue != value) 
							|| (this._DiliveryType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DiliveryType.Entity = null;
						previousValue.Orders.Remove(this);
					}
					this._DiliveryType.Entity = value;
					if ((value != null))
					{
						value.Orders.Add(this);
						this._DiliveryTypeId = value.Id;
					}
					else
					{
						this._DiliveryTypeId = default(int);
					}
					this.SendPropertyChanged("DiliveryType");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PaymentType_Order", Storage="_PaymentType", ThisKey="PaymentTypeId", OtherKey="Id", IsForeignKey=true)]
		public PaymentType PaymentType
		{
			get
			{
				return this._PaymentType.Entity;
			}
			set
			{
				PaymentType previousValue = this._PaymentType.Entity;
				if (((previousValue != value) 
							|| (this._PaymentType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PaymentType.Entity = null;
						previousValue.Orders.Remove(this);
					}
					this._PaymentType.Entity = value;
					if ((value != null))
					{
						value.Orders.Add(this);
						this._PaymentTypeId = value.Id;
					}
					else
					{
						this._PaymentTypeId = default(int);
					}
					this.SendPropertyChanged("PaymentType");
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
		
		private void attach_Link_ConcreteProduct_Orders(Link_ConcreteProduct_Order entity)
		{
			this.SendPropertyChanging();
			entity.Order = this;
		}
		
		private void detach_Link_ConcreteProduct_Orders(Link_ConcreteProduct_Order entity)
		{
			this.SendPropertyChanging();
			entity.Order = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PaymentType")]
	public partial class PaymentType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<Order> _Orders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public PaymentType()
		{
			this._Orders = new EntitySet<Order>(new Action<Order>(this.attach_Orders), new Action<Order>(this.detach_Orders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PaymentType_Order", Storage="_Orders", ThisKey="Id", OtherKey="PaymentTypeId")]
		public EntitySet<Order> Orders
		{
			get
			{
				return this._Orders;
			}
			set
			{
				this._Orders.Assign(value);
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
		
		private void attach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.PaymentType = this;
		}
		
		private void detach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.PaymentType = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private decimal _Price;
		
		private EntitySet<ConcreteProduct> _ConcreteProducts;
		
		private EntitySet<ProductDetail> _ProductDetails;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    #endregion
		
		public Product()
		{
			this._ConcreteProducts = new EntitySet<ConcreteProduct>(new Action<ConcreteProduct>(this.attach_ConcreteProducts), new Action<ConcreteProduct>(this.detach_ConcreteProducts));
			this._ProductDetails = new EntitySet<ProductDetail>(new Action<ProductDetail>(this.attach_ProductDetails), new Action<ProductDetail>(this.detach_ProductDetails));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Decimal(18,0) NOT NULL")]
		public decimal Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_ConcreteProduct", Storage="_ConcreteProducts", ThisKey="Id", OtherKey="ProductId")]
		public EntitySet<ConcreteProduct> ConcreteProducts
		{
			get
			{
				return this._ConcreteProducts;
			}
			set
			{
				this._ConcreteProducts.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_ProductDetail", Storage="_ProductDetails", ThisKey="Id", OtherKey="ProductId")]
		public EntitySet<ProductDetail> ProductDetails
		{
			get
			{
				return this._ProductDetails;
			}
			set
			{
				this._ProductDetails.Assign(value);
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
		
		private void attach_ConcreteProducts(ConcreteProduct entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_ConcreteProducts(ConcreteProduct entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
		
		private void attach_ProductDetails(ProductDetail entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_ProductDetails(ProductDetail entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ProductCategory")]
	public partial class ProductCategory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<ProductDetail> _ProductDetails;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public ProductCategory()
		{
			this._ProductDetails = new EntitySet<ProductDetail>(new Action<ProductDetail>(this.attach_ProductDetails), new Action<ProductDetail>(this.detach_ProductDetails));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ProductCategory_ProductDetail", Storage="_ProductDetails", ThisKey="Id", OtherKey="ProductCategoryId")]
		public EntitySet<ProductDetail> ProductDetails
		{
			get
			{
				return this._ProductDetails;
			}
			set
			{
				this._ProductDetails.Assign(value);
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
		
		private void attach_ProductDetails(ProductDetail entity)
		{
			this.SendPropertyChanging();
			entity.ProductCategory = this;
		}
		
		private void detach_ProductDetails(ProductDetail entity)
		{
			this.SendPropertyChanging();
			entity.ProductCategory = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ProductDetails")]
	public partial class ProductDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _ProductId;
		
		private int _ProductCategoryId;
		
		private string _Name;
		
		private string _Value;
		
		private EntityRef<Product> _Product;
		
		private EntityRef<ProductCategory> _ProductCategory;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnProductIdChanging(int value);
    partial void OnProductIdChanged();
    partial void OnProductCategoryIdChanging(int value);
    partial void OnProductCategoryIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnValueChanging(string value);
    partial void OnValueChanged();
    #endregion
		
		public ProductDetail()
		{
			this._Product = default(EntityRef<Product>);
			this._ProductCategory = default(EntityRef<ProductCategory>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="Int NOT NULL")]
		public int ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductCategoryId", DbType="Int NOT NULL")]
		public int ProductCategoryId
		{
			get
			{
				return this._ProductCategoryId;
			}
			set
			{
				if ((this._ProductCategoryId != value))
				{
					if (this._ProductCategory.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductCategoryIdChanging(value);
					this.SendPropertyChanging();
					this._ProductCategoryId = value;
					this.SendPropertyChanged("ProductCategoryId");
					this.OnProductCategoryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Value", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if ((this._Value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._Value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_ProductDetail", Storage="_Product", ThisKey="ProductId", OtherKey="Id", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.ProductDetails.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.ProductDetails.Add(this);
						this._ProductId = value.Id;
					}
					else
					{
						this._ProductId = default(int);
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ProductCategory_ProductDetail", Storage="_ProductCategory", ThisKey="ProductCategoryId", OtherKey="Id", IsForeignKey=true)]
		public ProductCategory ProductCategory
		{
			get
			{
				return this._ProductCategory.Entity;
			}
			set
			{
				ProductCategory previousValue = this._ProductCategory.Entity;
				if (((previousValue != value) 
							|| (this._ProductCategory.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ProductCategory.Entity = null;
						previousValue.ProductDetails.Remove(this);
					}
					this._ProductCategory.Entity = value;
					if ((value != null))
					{
						value.ProductDetails.Add(this);
						this._ProductCategoryId = value.Id;
					}
					else
					{
						this._ProductCategoryId = default(int);
					}
					this.SendPropertyChanged("ProductCategory");
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
}
#pragma warning restore 1591