using System;
using Tetris_WPF.Blocks;

namespace Tetris_WPF
{
    public class BlockQueue
    {
        private readonly Random random = new Random();

        public BlockQueue()
        {
            NextBlock = RandomBlock();
        }

        private readonly Block[] blocks = new Block[]
        {
            new IBlock(),
            new JBlock(),
            new LBlock(),
            new OBlock(),
            new SBlock(),
            new TBlock(),
            new ZBlock()
        };

        public Block NextBlock { get; private set; }

        private Block RandomBlock() => blocks[random.Next(blocks.Length)];

        public Block GetAndUpdate()
        {
            Block block = NextBlock;

            do
            {
                NextBlock = RandomBlock();
            } while (block.Id == NextBlock.Id);

            return block;
        }
    }
}
