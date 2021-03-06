#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoesStoreWebApplication.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ShoesDataBase")]
	public partial class KidShoesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKidShoe(KidShoe instance);
    partial void UpdateKidShoe(KidShoe instance);
    partial void DeleteKidShoe(KidShoe instance);
    #endregion
		
		public KidShoesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ShoesDataBaseConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public KidShoesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KidShoesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KidShoesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KidShoesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<KidShoe> KidShoes
		{
			get
			{
				return this.GetTable<KidShoe>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KidShoes")]
	public partial class KidShoe : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _ComanyName;
		
		private string _Matirial;
		
		private bool _IsExsist;
		
		private int _Price;
		
		private int _Size;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnComanyNameChanging(string value);
    partial void OnComanyNameChanged();
    partial void OnMatirialChanging(string value);
    partial void OnMatirialChanged();
    partial void OnIsExsistChanging(bool value);
    partial void OnIsExsistChanged();
    partial void OnPriceChanging(int value);
    partial void OnPriceChanged();
    partial void OnSizeChanging(int value);
    partial void OnSizeChanged();
    #endregion
		
		public KidShoe()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ComanyName", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string ComanyName
		{
			get
			{
				return this._ComanyName;
			}
			set
			{
				if ((this._ComanyName != value))
				{
					this.OnComanyNameChanging(value);
					this.SendPropertyChanging();
					this._ComanyName = value;
					this.SendPropertyChanged("ComanyName");
					this.OnComanyNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Matirial", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Matirial
		{
			get
			{
				return this._Matirial;
			}
			set
			{
				if ((this._Matirial != value))
				{
					this.OnMatirialChanging(value);
					this.SendPropertyChanging();
					this._Matirial = value;
					this.SendPropertyChanged("Matirial");
					this.OnMatirialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsExsist", DbType="Bit NOT NULL")]
		public bool IsExsist
		{
			get
			{
				return this._IsExsist;
			}
			set
			{
				if ((this._IsExsist != value))
				{
					this.OnIsExsistChanging(value);
					this.SendPropertyChanging();
					this._IsExsist = value;
					this.SendPropertyChanged("IsExsist");
					this.OnIsExsistChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Int NOT NULL")]
		public int Price
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Size", DbType="Int NOT NULL")]
		public int Size
		{
			get
			{
				return this._Size;
			}
			set
			{
				if ((this._Size != value))
				{
					this.OnSizeChanging(value);
					this.SendPropertyChanging();
					this._Size = value;
					this.SendPropertyChanged("Size");
					this.OnSizeChanged();
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
