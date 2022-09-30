using FluentValidation;
using YukselenWebAPI.DAL.ViewModel;

namespace YukselenWebAPI.BL.Validators
{
    public class SubdoshaValidation : AbstractValidator<VM_Subdosha>
    {
        public SubdoshaValidation()
        {
            // f1 

            RuleForEach(s => s.f1_vata).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));
            RuleForEach(s => s.f1_pıtta).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));
            RuleForEach(s => s.f1_kapha).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            // f2 vata zihin

            RuleFor(s => s.f2_vata_zihin_1).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f2_vata_zihin_2).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f2_vata_zihin_3).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f2_vata_zihin_4).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f2_vata_zihin_5).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f2_vata_zihin_6).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f2_vata_zihin_7).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f2_vata_zihin_8) .Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f2_vata_zihin_9).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f2_vata_zihin_10).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            // f2 vata beden

            RuleFor(s => s.f2_vata_beden_1).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f2_vata_beden_2).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f2_vata_beden_3).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f2_vata_beden_4).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f2_vata_beden_5).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f2_vata_beden_6).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f2_vata_beden_7).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f2_vata_beden_8).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f2_vata_beden_9).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f2_vata_beden_10).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            // f3 pıtta zihin

            RuleFor(s => s.f3_pıtta_zihin_1).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f3_pıtta_zihin_2).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f3_pıtta_zihin_3).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f3_pıtta_zihin_4).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f3_pıtta_zihin_5).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f3_pıtta_zihin_6).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f3_pıtta_zihin_7).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f3_pıtta_zihin_8).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f3_pıtta_zihin_9).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f3_pıtta_zihin_10).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));


            // f3 pıtta beden

            RuleFor(s => s.f3_pıtta_beden_1).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f3_pıtta_beden_2).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f3_pıtta_beden_3).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f3_pıtta_beden_4).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f3_pıtta_beden_5).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f3_pıtta_beden_6).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f3_pıtta_beden_7).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f3_pıtta_beden_8).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f3_pıtta_beden_9).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f3_pıtta_beden_10).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));



            // f4 kapha zihin

            RuleFor(s => s.f4_kapha_zihin_1).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f4_kapha_zihin_2).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f4_kapha_zihin_3).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f4_kapha_zihin_4).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f4_kapha_zihin_5).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f4_kapha_zihin_6).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f4_kapha_zihin_7).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f4_kapha_zihin_8).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f4_kapha_zihin_9).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f4_kapha_zihin_10).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));


            // f4 kapha beden

            RuleFor(s => s.f4_kapha_beden_1).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f4_kapha_beden_2).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f4_kapha_beden_3).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f4_kapha_beden_4).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f4_kapha_beden_5).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f4_kapha_beden_6).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f4_kapha_beden_7).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f4_kapha_beden_8).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f4_kapha_beden_9).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));

            RuleFor(s => s.f4_kapha_beden_10).Must(x => x.Equals(1) || x.Equals(3) || x.Equals(5));


            RuleFor(s => s.f5_kilo_1)
                .NotNull()
                .NotEmpty();

            RuleFor(s => s.f5_kilo_2)
                .NotNull()
                .NotEmpty();

            RuleFor(s => s.f5_kilo_3)
                .NotNull()
                .NotEmpty();

        }
    }
}
