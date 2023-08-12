
using XP.TableModel;

namespace Scripts.GameData
{
    public class GameInformation
    {
        [Column(0)]
        public string Name { get => name; set => name = value; }

        string name;
        
        [Column(1, "阵位")]
        public string posistion { get; set; }
        
        [Column(2, "体能")]
        public int Strength { get; set; } = 50;
        
        [Column(3, "加速度")]
        public int Acceleration { get; set; } = 50;
        
        [Column(4, "速度")]
        public int TopSpeed { get; set; } = 50;
        
        [Column(5, "带足球的速度")]
        public int DribbleSpeed { get; set; } = 50;
        
        [Column(6, "跳跃")]
        public int Jump { get; set; } = 50;
        
        [Column(7, "拦截")]
        public int Tackling { get; set; } = 50;
        
        [Column(8, "球保持")]
        public int BallKeeping { get; set; } = 50;
        
        [Column(9, "传")]
        public int Passing { get; set; } = 50;
        
        [Column(10, "长传球")]
        public int LongBall { get; set; } = 50;
        
        [Column(11, "灵敏度")]
        public int Agility { get; set; } = 50;
        
        [Column(12, "踢球")]
        public int Shooting { get; set; } = 50;
        
        [Column(13, "踢球力")]
        public int ShootPower { get; set; } = 50;
        
        [Column(14, "站位")]
        public int Positioning { get; set; } = 50;
        
        [Column(15, "反馈力")]
        public int Reaction { get; set; } = 50;
        
        [Column(16, "控球")]
        public int BallControl { get; set; } = 50;
    }
}