namespace Minigame.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rank")]
    public partial class rank
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(30)]
        public string name { get; set; }

        public int? score { get; set; }

        [StringLength(50)]
        public string theme { get; set; }

        [Column(TypeName = "date")]
        public DateTime? timeplay { get; set; }
    }
}
