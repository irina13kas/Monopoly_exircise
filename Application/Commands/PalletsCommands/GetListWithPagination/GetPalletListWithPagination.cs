using FluentValidation;

namespace Application.Commands.PalletsCommands.Validation
{
    public class GetPalletListWithPagination : AbstractValidator<GetPalletListWithPaginationCommand>
    {
        //добавить проверку, что столько палетов можно взять

        //private readonly DbStorageContext Db;
        public GetPalletListWithPagination()
        {
            //RuleFor(pallet =>
            //  pallet.Limit).NotNull().LessThan().GreaterThan(0);
            RuleFor(pallet =>
                pallet.Offset).NotNull().GreaterThan(0);

        }

    }
}
