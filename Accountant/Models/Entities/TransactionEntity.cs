namespace Accountant.Models.Entities
{
    /// <summary>
    /// Сущность оплаты.
    /// </summary>
    public class TransactionEntity : BaseEntity
    {
        /// <summary>
        /// Сумма выполненой оплаты.
        /// </summary>
        public decimal Sum { get; set; }
        /// <summary>
        /// Дата выполненой оплаты.
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Коментарий выполненой оплаты.
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// Идентификатор категории оплаты.
        /// </summary>
        public Guid CategoryId { get; set; }

        /// <summary>
        /// Навигационное поле категории оплаты.
        /// </summary>
        public TransactionCategoryEntity Category { get; set; }
    }
}
