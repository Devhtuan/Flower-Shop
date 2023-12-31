﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlowerShop.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER()
        {
            this.ORDERS = new HashSet<ORDER>();
            this.SHOPPINGCARTs = new HashSet<SHOPPINGCART>();
            this.USERDISCOUNTs = new HashSet<USERDISCOUNT>();
        }
        [DisplayName("Mã người dùng")]
        public System.Guid USER_ID { get; set; }

        [DisplayName("Họ tên")]
        [Required(ErrorMessage = "Tên người dùng không được để trống")]
        [MinLength(3, ErrorMessage = "Tên người dùng phải có ít nhất {1} ký tự")]
        [MaxLength(100, ErrorMessage = "Vượt quá giới hạn ký tự")]
        public string USER_NAME { get; set; }

        [DisplayName("Địa chỉ Email")]
        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string USER_EMAIL { get; set; }

        [DisplayName("Số điện thoại")]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [RegularExpression(@"^\d{10,15}$", ErrorMessage = "Số điện thoại phải là số từ 10 đến 15 ký tự")]
        public string USER_PHONE { get; set; }

        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [RegularExpression(@"^(?=.*[a-zA-Z])(?=.*\d).{6,}$", ErrorMessage = "Mật khẩu phải có ít nhất 6 ký tự, 1 chữ cái và 1 ký tự số")]
        [MaxLength(100, ErrorMessage = "Mật khẩu có tối đa 100 ký tự")]
        public string USER_PASSWORD { get; set; }

        [NotMapped]
        [DisplayName("Xác nhận mật khẩu")]
        public string CONFIRM_PASSWORD { get; set; }

        public bool DELETED { get; set; }

        [DisplayName("Quyền")]
        public bool ROLE { get; set; }
        public string FACEBOOKID { get; set; }
        public Nullable<System.Guid> RESETTOKEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER> ORDERS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SHOPPINGCART> SHOPPINGCARTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USERDISCOUNT> USERDISCOUNTs { get; set; }
    }
}
