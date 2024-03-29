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

namespace Shepard_Hawj_CPT_206_A01S_Lab_2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="StateInfoDB")]
	public partial class StateInfoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertStateInformation(StateInformation instance);
    partial void UpdateStateInformation(StateInformation instance);
    partial void DeleteStateInformation(StateInformation instance);
    #endregion
		
		public StateInfoDataContext() : 
				base(global::Shepard_Hawj_CPT_206_A01S_Lab_2.Properties.Settings.Default.StateInfoDBConnection, mappingSource)
		{
			OnCreated();
		}
		
		public StateInfoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StateInfoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StateInfoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StateInfoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<StateInformation> StateInformations
		{
			get
			{
				return this.GetTable<StateInformation>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.StateInformation")]
	public partial class StateInformation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _State_Name;
		
		private System.Nullable<int> _State_Pop;
		
		private string _State_Flag_Des;
		
		private string _State_Flower;
		
		private string _State_Bird;
		
		private string _State_Colors;
		
		private string _State_Larg_Cities;
		
		private string _State_Capital;
		
		private System.Nullable<int> _State_Med_Income;
		
		private System.Nullable<double> _State_Perc_CompJob;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnState_NameChanging(string value);
    partial void OnState_NameChanged();
    partial void OnState_PopChanging(System.Nullable<int> value);
    partial void OnState_PopChanged();
    partial void OnState_Flag_DesChanging(string value);
    partial void OnState_Flag_DesChanged();
    partial void OnState_FlowerChanging(string value);
    partial void OnState_FlowerChanged();
    partial void OnState_BirdChanging(string value);
    partial void OnState_BirdChanged();
    partial void OnState_ColorsChanging(string value);
    partial void OnState_ColorsChanged();
    partial void OnState_Larg_CitiesChanging(string value);
    partial void OnState_Larg_CitiesChanged();
    partial void OnState_CapitalChanging(string value);
    partial void OnState_CapitalChanged();
    partial void OnState_Med_IncomeChanging(System.Nullable<int> value);
    partial void OnState_Med_IncomeChanged();
    partial void OnState_Perc_CompJobChanging(System.Nullable<double> value);
    partial void OnState_Perc_CompJobChanged();
    #endregion
		
		public StateInformation()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State_Name", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string State_Name
		{
			get
			{
				return this._State_Name;
			}
			set
			{
				if ((this._State_Name != value))
				{
					this.OnState_NameChanging(value);
					this.SendPropertyChanging();
					this._State_Name = value;
					this.SendPropertyChanged("State_Name");
					this.OnState_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State_Pop", DbType="Int")]
		public System.Nullable<int> State_Pop
		{
			get
			{
				return this._State_Pop;
			}
			set
			{
				if ((this._State_Pop != value))
				{
					this.OnState_PopChanging(value);
					this.SendPropertyChanging();
					this._State_Pop = value;
					this.SendPropertyChanged("State_Pop");
					this.OnState_PopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State_Flag_Des", DbType="NVarChar(MAX)")]
		public string State_Flag_Des
		{
			get
			{
				return this._State_Flag_Des;
			}
			set
			{
				if ((this._State_Flag_Des != value))
				{
					this.OnState_Flag_DesChanging(value);
					this.SendPropertyChanging();
					this._State_Flag_Des = value;
					this.SendPropertyChanged("State_Flag_Des");
					this.OnState_Flag_DesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State_Flower", DbType="VarChar(50)")]
		public string State_Flower
		{
			get
			{
				return this._State_Flower;
			}
			set
			{
				if ((this._State_Flower != value))
				{
					this.OnState_FlowerChanging(value);
					this.SendPropertyChanging();
					this._State_Flower = value;
					this.SendPropertyChanged("State_Flower");
					this.OnState_FlowerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State_Bird", DbType="VarChar(50)")]
		public string State_Bird
		{
			get
			{
				return this._State_Bird;
			}
			set
			{
				if ((this._State_Bird != value))
				{
					this.OnState_BirdChanging(value);
					this.SendPropertyChanging();
					this._State_Bird = value;
					this.SendPropertyChanged("State_Bird");
					this.OnState_BirdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State_Colors", DbType="VarChar(50)")]
		public string State_Colors
		{
			get
			{
				return this._State_Colors;
			}
			set
			{
				if ((this._State_Colors != value))
				{
					this.OnState_ColorsChanging(value);
					this.SendPropertyChanging();
					this._State_Colors = value;
					this.SendPropertyChanged("State_Colors");
					this.OnState_ColorsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State_Larg_Cities", DbType="VarChar(50)")]
		public string State_Larg_Cities
		{
			get
			{
				return this._State_Larg_Cities;
			}
			set
			{
				if ((this._State_Larg_Cities != value))
				{
					this.OnState_Larg_CitiesChanging(value);
					this.SendPropertyChanging();
					this._State_Larg_Cities = value;
					this.SendPropertyChanged("State_Larg_Cities");
					this.OnState_Larg_CitiesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State_Capital", DbType="VarChar(50)")]
		public string State_Capital
		{
			get
			{
				return this._State_Capital;
			}
			set
			{
				if ((this._State_Capital != value))
				{
					this.OnState_CapitalChanging(value);
					this.SendPropertyChanging();
					this._State_Capital = value;
					this.SendPropertyChanged("State_Capital");
					this.OnState_CapitalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State_Med_Income", DbType="Int")]
		public System.Nullable<int> State_Med_Income
		{
			get
			{
				return this._State_Med_Income;
			}
			set
			{
				if ((this._State_Med_Income != value))
				{
					this.OnState_Med_IncomeChanging(value);
					this.SendPropertyChanging();
					this._State_Med_Income = value;
					this.SendPropertyChanged("State_Med_Income");
					this.OnState_Med_IncomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State_Perc_CompJob", DbType="Float")]
		public System.Nullable<double> State_Perc_CompJob
		{
			get
			{
				return this._State_Perc_CompJob;
			}
			set
			{
				if ((this._State_Perc_CompJob != value))
				{
					this.OnState_Perc_CompJobChanging(value);
					this.SendPropertyChanging();
					this._State_Perc_CompJob = value;
					this.SendPropertyChanged("State_Perc_CompJob");
					this.OnState_Perc_CompJobChanged();
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
