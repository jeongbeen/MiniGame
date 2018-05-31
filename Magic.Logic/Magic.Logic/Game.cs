using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.Logic
{
    public class Game
    {
        public Game()
        {
            _cubes = new List<Cube>();
            _putCube = new Dictionary<int, Cube>();

            for (int i = 0; i < 9; i++)
            {
                _cubes.Add(new Cube(0));
                _putCube.Add(i + 1, _cubes[i]);
            }
        }

        private List<Cube> _cubes;
        private Dictionary<int, Cube> _putCube;

        public int GetNum(int num)
        {
            return _putCube[num].CubeNum;
        }

        public void Put(int putPosition, int cubeNum)
        {
            int count = 0;

            for (int i = 0; i < 9; i++)
            {
                if (cubeNum == _putCube[i+1].CubeNum) count++;
            }
            if (count == 0)
            {
                _cubes[putPosition - 1].CubeNum = cubeNum;
                _putCube[putPosition] = _cubes[putPosition - 1];
            }

        }
        public int this[int cubeNum]
        {
            get { return GetNum(cubeNum); }
        }
        public bool IsCompleted()
        {
            return ((_putCube[1].CubeNum + _putCube[5].CubeNum + _putCube[9].CubeNum) == 15) && ((_putCube[3].CubeNum + _putCube[5].CubeNum + _putCube[7].CubeNum) == 15) && ((_putCube[1].CubeNum + _putCube[2].CubeNum + _putCube[3].CubeNum) == 15);
        }
        public void Restart()
        {
            for (int i = 0; i < 9; i++)
            {
                _cubes[i].CubeNum = 0;
                _putCube[i+1] = _cubes[i];
            }
        }
    }

}
