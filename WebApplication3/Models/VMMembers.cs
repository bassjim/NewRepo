using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class VMMembers
    {
        [DisplayName("帳號")]
        [Required(ErrorMessage = "請填寫帳號")]
        [StringLength(20, ErrorMessage = "帳號不得超過12字")]
        [RegularExpression("[A-Za-z][A-Za-z0-9]{4,19}", ErrorMessage = "帳號格式錯誤")]
        public string account { get; set; }

        [DisplayName("密碼")]
        [Required(ErrorMessage = "請填寫密碼")]
        [DataType(DataType.Password)]
        [MinLength(4, ErrorMessage = "密碼最少4碼")]
        [MaxLength(12, ErrorMessage = "密碼最多12碼")]
        public string passeard { get; set; }

        [DisplayName("再次確認密碼")]
        [Required(ErrorMessage = "請填寫密碼")]
        [DataType(DataType.Password)]
        [MinLength(4, ErrorMessage = "密碼最少4碼")]
        [MaxLength(12, ErrorMessage = "密碼最多12碼")]
        [System.ComponentModel.DataAnnotations.Compare("passeard", ErrorMessage = "兩次輸入不同")]
        public string comfirmpasseard { get; set; }

        public string email { get; set; }
    }
}