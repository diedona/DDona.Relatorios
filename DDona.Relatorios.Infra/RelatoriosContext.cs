﻿

// ------------------------------------------------------------------------------------------------
// This code was generated by EntityFramework Reverse POCO Generator (http://www.reversepoco.com/).
// Created by Simon Hughes (https://about.me/simon.hughes).
// 
// Do not make changes directly to this file - edit the template instead.
// 
// The following connection settings were used to generate this file:
//     Configuration file:     "DDona.Relatorios.Infra\App.config"
//     Connection String Name: "RelatoriosContext"
//     Connection String:      "Server=.\SQLExpress;Database=Relatorios;User Id=sa; password=**zapped**;;MultipleActiveResultSets=true;"
// ------------------------------------------------------------------------------------------------
// Database Edition       : Express Edition (64-bit)
// Database Engine Edition: Express

// <auto-generated>
// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Entity.ModelConfiguration;
using System.Threading;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace DDona.Relatorios.Infra
{
    // ************************************************************************
    // Unit of work
    public interface IRelatoriosContext : IDisposable
    {
        DbSet<Loja> Loja { get; set; } // Loja
        DbSet<Produto> Produto { get; set; } // Produto
        DbSet<Sysdiagrams> Sysdiagrams { get; set; } // sysdiagrams

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        
        // Stored Procedures
    }

    // ************************************************************************
    // Database context
    public class RelatoriosContext : DbContext, IRelatoriosContext
    {
        public DbSet<Loja> Loja { get; set; } // Loja
        public DbSet<Produto> Produto { get; set; } // Produto
        public DbSet<Sysdiagrams> Sysdiagrams { get; set; } // sysdiagrams
        
        static RelatoriosContext()
        {
            System.Data.Entity.Database.SetInitializer<RelatoriosContext>(null);
        }

        public RelatoriosContext()
            : base("Name=RelatoriosContext")
        {
        }

        public RelatoriosContext(string connectionString) : base(connectionString)
        {
        }

        public RelatoriosContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == DBNull.Value);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new LojaConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
            modelBuilder.Configurations.Add(new SysdiagramsConfiguration());
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new LojaConfiguration(schema));
            modelBuilder.Configurations.Add(new ProdutoConfiguration(schema));
            modelBuilder.Configurations.Add(new SysdiagramsConfiguration(schema));
            return modelBuilder;
        }
        
        // Stored Procedures
    }

    // ************************************************************************
    // Fake Database context
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.16.1.0")]
    public class FakeRelatoriosContext : IRelatoriosContext
    {
        public DbSet<Loja> Loja { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Sysdiagrams> Sysdiagrams { get; set; }

        public FakeRelatoriosContext()
        {
            Loja = new FakeDbSet<Loja>();
            Produto = new FakeDbSet<Produto>();
            Sysdiagrams = new FakeDbSet<Sysdiagrams>();
        }
        
        public int SaveChangesCount { get; private set; } 
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
        }
        
        public void Dispose()
        {
            Dispose(true);
        }
        
        // Stored Procedures
    }

    // ************************************************************************
    // Fake DbSet
    // Implementing Find:
    //      The Find method is difficult to implement in a generic fashion. If
    //      you need to test code that makes use of the Find method it is
    //      easiest to create a test DbSet for each of the entity types that
    //      need to support find. You can then write logic to find that
    //      particular type of entity, as shown below:
    //      public class FakeBlogDbSet : FakeDbSet<Blog>
    //      {
    //          public override Blog Find(params object[] keyValues)
    //          {
    //              var id = (int) keyValues.Single();
    //              return this.SingleOrDefault(b => b.BlogId == id);
    //          }
    //      }
    //      Read more about it here: https://msdn.microsoft.com/en-us/data/dn314431.aspx
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.16.1.0")]
    public class FakeDbSet<TEntity> : DbSet<TEntity>, IQueryable, IEnumerable<TEntity>, IDbAsyncEnumerable<TEntity> 
        where TEntity : class 
    { 
        private readonly ObservableCollection<TEntity> _data;
        private readonly IQueryable _query;
 
        public FakeDbSet() 
        { 
            _data = new ObservableCollection<TEntity>(); 
            _query = _data.AsQueryable(); 
        }

        public override IEnumerable<TEntity> AddRange(IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new ArgumentNullException("entities");
            var items = entities.ToList();
            foreach (var entity in items)
            {
                _data.Add(entity);
            }
            return items;
        }
        
        public override TEntity Add(TEntity item) 
        {
            if (item == null) throw new ArgumentNullException("item");
            _data.Add(item); 
            return item; 
        } 
 
        public override TEntity Remove(TEntity item) 
        {
            if (item == null) throw new ArgumentNullException("item");
            _data.Remove(item); 
            return item; 
        } 
 
        public override TEntity Attach(TEntity item) 
        {
            if (item == null) throw new ArgumentNullException("item");
            _data.Add(item); 
            return item; 
        } 
 
        public override TEntity Create() 
        { 
            return Activator.CreateInstance<TEntity>(); 
        } 
 
        public override TDerivedEntity Create<TDerivedEntity>() 
        { 
            return Activator.CreateInstance<TDerivedEntity>(); 
        } 
 
        public override ObservableCollection<TEntity> Local 
        { 
            get { return _data; } 
        } 
 
        Type IQueryable.ElementType 
        { 
            get { return _query.ElementType; } 
        } 
 
        Expression IQueryable.Expression 
        { 
            get { return _query.Expression; } 
        } 
 
        IQueryProvider IQueryable.Provider 
        { 
            get { return new FakeDbAsyncQueryProvider<TEntity>(_query.Provider); } 
        } 
 
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() 
        { 
            return _data.GetEnumerator(); 
        } 
 
        IEnumerator<TEntity> IEnumerable<TEntity>.GetEnumerator() 
        { 
            return _data.GetEnumerator(); 
        } 
 
        IDbAsyncEnumerator<TEntity> IDbAsyncEnumerable<TEntity>.GetAsyncEnumerator() 
        { 
            return new FakeDbAsyncEnumerator<TEntity>(_data.GetEnumerator()); 
        }
    } 
 
    public class FakeDbAsyncQueryProvider<TEntity> : IDbAsyncQueryProvider 
    { 
        private readonly IQueryProvider _inner; 
 
        public FakeDbAsyncQueryProvider(IQueryProvider inner) 
        { 
            _inner = inner; 
        } 
 
        public IQueryable CreateQuery(Expression expression) 
        { 
            return new FakeDbAsyncEnumerable<TEntity>(expression); 
        } 
 
        public IQueryable<TElement> CreateQuery<TElement>(Expression expression) 
        { 
            return new FakeDbAsyncEnumerable<TElement>(expression); 
        } 
 
        public object Execute(Expression expression) 
        { 
            return _inner.Execute(expression); 
        } 
 
        public TResult Execute<TResult>(Expression expression) 
        { 
            return _inner.Execute<TResult>(expression); 
        } 
 
        public System.Threading.Tasks.Task<object> ExecuteAsync(Expression expression, CancellationToken cancellationToken) 
        { 
            return System.Threading.Tasks.Task.FromResult(Execute(expression)); 
        } 
 
        public System.Threading.Tasks.Task<TResult> ExecuteAsync<TResult>(Expression expression, CancellationToken cancellationToken) 
        { 
            return System.Threading.Tasks.Task.FromResult(Execute<TResult>(expression)); 
        } 
    } 
 
    public class FakeDbAsyncEnumerable<T> : EnumerableQuery<T>, IDbAsyncEnumerable<T>, IQueryable<T> 
    { 
        public FakeDbAsyncEnumerable(IEnumerable<T> enumerable) 
            : base(enumerable) 
        { } 
 
        public FakeDbAsyncEnumerable(Expression expression) 
            : base(expression) 
        { } 
 
        public IDbAsyncEnumerator<T> GetAsyncEnumerator() 
        { 
            return new FakeDbAsyncEnumerator<T>(this.AsEnumerable().GetEnumerator()); 
        } 
 
        IDbAsyncEnumerator IDbAsyncEnumerable.GetAsyncEnumerator() 
        { 
            return GetAsyncEnumerator(); 
        } 
 
        IQueryProvider IQueryable.Provider 
        { 
            get { return new FakeDbAsyncQueryProvider<T>(this); } 
        } 
    } 
 
    public class FakeDbAsyncEnumerator<T> : IDbAsyncEnumerator<T> 
    { 
        private readonly IEnumerator<T> _inner; 
 
        public FakeDbAsyncEnumerator(IEnumerator<T> inner) 
        { 
            _inner = inner; 
        } 
 
        public void Dispose() 
        { 
            _inner.Dispose(); 
        } 
 
        public System.Threading.Tasks.Task<bool> MoveNextAsync(CancellationToken cancellationToken) 
        { 
            return System.Threading.Tasks.Task.FromResult(_inner.MoveNext()); 
        } 
 
        public T Current 
        { 
            get { return _inner.Current; } 
        } 
 
        object IDbAsyncEnumerator.Current 
        { 
            get { return Current; } 
        } 
    }

    // ************************************************************************
    // POCO classes

    // Loja
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.16.1.0")]
    public class Loja
    {
        public int Codigo { get; set; } // Codigo (Primary key)
        public string Nome { get; set; } // Nome
        public int? Nota { get; set; } // Nota
        public decimal? Investimento { get; set; } // Investimento

        // Reverse navigation
        public virtual ICollection<Produto> Produto { get; set; } // Many to many mapping
        
        public Loja()
        {
            Produto = new List<Produto>();
        }
    }

    // Produto
    public class Produto
    {
        public int LojaCodigo { get; set; } // LojaCodigo (Primary key)
        public int Codigo { get; set; } // Codigo (Primary key)
        public string Nome { get; set; } // Nome
        public decimal PrecoCompra { get; set; } // PrecoCompra
        public decimal PrecoVenda { get; set; } // PrecoVenda

        // Foreign keys
        public virtual Loja Loja { get; set; } // FK_Produto_Loja
    }

    // sysdiagrams
    public class Sysdiagrams
    {
        public string Name { get; set; } // name
        public int PrincipalId { get; set; } // principal_id
        public int DiagramId { get; set; } // diagram_id (Primary key)
        public int? Version { get; set; } // version
        public byte[] Definition { get; set; } // definition
    }


    // ************************************************************************
    // POCO Configuration

    // Loja
    public class LojaConfiguration : EntityTypeConfiguration<Loja>
    {
        public LojaConfiguration()
            : this("dbo")
        {
        }
 
        public LojaConfiguration(string schema)
        {
            ToTable(schema + ".Loja");
            HasKey(x => x.Codigo);

            Property(x => x.Codigo).HasColumnName("Codigo").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Nome).HasColumnName("Nome").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(80);
            Property(x => x.Nota).HasColumnName("Nota").IsOptional().HasColumnType("int");
            Property(x => x.Investimento).HasColumnName("Investimento").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
        }
    }

    // Produto
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
            : this("dbo")
        {
        }
 
        public ProdutoConfiguration(string schema)
        {
            ToTable(schema + ".Produto");
            HasKey(x => new { x.LojaCodigo, x.Codigo });

            Property(x => x.LojaCodigo).HasColumnName("LojaCodigo").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Codigo).HasColumnName("Codigo").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Nome).HasColumnName("Nome").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(80);
            Property(x => x.PrecoCompra).HasColumnName("PrecoCompra").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.PrecoVenda).HasColumnName("PrecoVenda").IsRequired().HasColumnType("decimal").HasPrecision(10,2);

            // Foreign keys
            HasRequired(a => a.Loja).WithMany(b => b.Produto).HasForeignKey(c => c.LojaCodigo); // FK_Produto_Loja
        }
    }

    // sysdiagrams
    public class SysdiagramsConfiguration : EntityTypeConfiguration<Sysdiagrams>
    {
        public SysdiagramsConfiguration()
            : this("dbo")
        {
        }
 
        public SysdiagramsConfiguration(string schema)
        {
            ToTable(schema + ".sysdiagrams");
            HasKey(x => x.DiagramId);

            Property(x => x.Name).HasColumnName("name").IsRequired().HasColumnType("nvarchar").HasMaxLength(128);
            Property(x => x.PrincipalId).HasColumnName("principal_id").IsRequired().HasColumnType("int");
            Property(x => x.DiagramId).HasColumnName("diagram_id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Version).HasColumnName("version").IsOptional().HasColumnType("int");
            Property(x => x.Definition).HasColumnName("definition").IsOptional().HasColumnType("varbinary");
        }
    }


    // ************************************************************************
    // Stored procedure return models

}
// </auto-generated>

