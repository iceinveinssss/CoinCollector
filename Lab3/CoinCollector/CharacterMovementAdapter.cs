namespace CoinCollector;

public class CharacterMovementAdapter : ICharacterMovement
{
    private readonly LegacyCharacter _legacyCharacter;

    public CharacterMovementAdapter(LegacyCharacter legacyCharacter)
    {
        _legacyCharacter = legacyCharacter;
    }

    public void Move(Position position)
    {
        _legacyCharacter.MoveCharacter(position.X, position.Y);
    }
}
