using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace btc.Domain.Entiity
{
	public abstract class BaseEntity
	{
		/// <summary>
		/// Chave de identificação do registro
		/// </summary>
		[Key]
		public Guid Id { get; set; }

		private DateTime? _CreateAt;

		/// <summary>
		/// Data de criação do registro
		/// </summary>
		public DateTime? CreateAt
		{
			get { return _CreateAt; }
			set { _CreateAt = (value == null ? DateTime.UtcNow : value); }
		}

		/// <summary>
		/// Data da última modificação do registro
		/// </summary>
		public DateTime? UpdateAt { get; set; }

		private bool? _Ativo;

		/// <summary>
		/// identificação de registro ativo
		/// </summary>
		public bool? Ativo
		{
			get { return _Ativo; }
			set { _Ativo = (value == null ? true : value); }
		}


	}
}
