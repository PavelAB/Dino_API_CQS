using Dino_API_CQS.Models.Dino;
using Dino_API_Domain.Commands;

namespace Dino_API_CQS.Mappers
{
    internal static class Mapper
    {
        public static CreateDinoCommand ToCreateDinoCommand(this DinoCreate entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
            return new CreateDinoCommand(entity.Spece, entity.Weight, entity.Size);
        }

    }
}
