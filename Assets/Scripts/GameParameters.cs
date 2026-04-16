using UnityEngine;
using UnityEngine.InputSystem;

public static class GameParameters
{
    public static float PlayerSpeed = 5f;
    public static float PlayerAttackCooldown = 1f;


    public static int EnemyDamage = 1;
    public static int EnemyAttackRange = 2;
    public static int EnemyAttackCooldown = 2;
    public static int EnemyDetectRange = 5;
    public static float EnemyMinSpawnDelay = 1f;
    public static float EnemyMaxSpawnDelay = 3f;
    public static int EnemyMaxSpawnAttempts = 100;
    public static float EnemySpeed = 3f;
    
    public static Key MoveLeft  = Key.A;
    public static Key MoveRight = Key.D;
    public static Key MoveUp    = Key.W;
    public static Key MoveDown  = Key.S;
    public static Key AttackKey  = Key.Space;
    
    public static Key PlaceKey  = Key.E;
    public static Key PickupKey = Key.F;
}
