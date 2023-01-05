/// <summary>
/// FactoryのProductにあたる抽象クラス
/// </summary>
public abstract class Character
{
    protected string name;
    protected int damage;

    public abstract void Attack();
}
