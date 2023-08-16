namespace Accountant.Models.Entities
{
    /// <summary>
    /// Сущность категорий оплат.
    /// </summary>
    public class TransactionCategoryEntity : BaseEntity
    {
        /// <summary>
        /// Название категории оплат.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание категории оплат.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Навигационное поле оплат.
        /// </summary>
        public ICollection<TransactionEntity> Transactions { get; set; }
    }
}
