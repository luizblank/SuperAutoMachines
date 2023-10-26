public interface BattleFactory
{
    Player Player { get; set; }
    Enemy Enemy { get; set; }
    public void Attack();
    public void Kill();
    public void NextRound();
    public void StartRoundBattle();
    public void BattleBuild();
    public void EndRoundBattle();
}