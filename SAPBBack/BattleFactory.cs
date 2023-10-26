public interface BattleFactory
{
    Player Player { get; set; }
    Enemy Enemy { get; set; }
    public void Attack();
    public void Kill();
    public void NextRound();
    public void StartBattle();
    public void BattleBuild(Player player, Enemy enemy);
    public void EndBattle();
}