using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAProject
{
    class A_star
    {
        // Coordinates of a cell - implements the method Equals
        public class Coordinates : IEquatable<Coordinates>
        {
            public int row;
            public int col;

            public Coordinates() { this.row = -1; this.col = -1; }
            public Coordinates(int row, int col) { this.row = row; this.col = col; }

            public Boolean Equals(Coordinates c)
            {
                if (this.row == c.row && this.col == c.col)
                    return true;
                else
                    return false;
            }
        }

        // Class Cell, with the cost to reach it, the values g and f, and the coordinates
        // of the cell that precedes it in a possible path
        public class Cell
        {
            public int cost;
            public int g;
            public int f;
            public Coordinates parent;
        }

        // Class Astar, which finds the shortest path
        public class Astar
        {
            // The array of the cells
            public Cell[,] cells = new Cell[8, 8];
            // The possible path found
            public List<Coordinates> path = new List<Coordinates>();
            // The list of the opened cells
            public List<Coordinates> opened = new List<Coordinates>();
            // The list of the closed cells
            public List<Coordinates> closed = new List<Coordinates>();
            // The start of the searched path
            public Coordinates startCell = new Coordinates(0, 0);
            // The end of the searched path
            public Coordinates finishCell = new Coordinates(7, 7);
            public int level = 0;
            public int rng = 0;

            // The constructor
            public Astar(int level, int rng)
            {
                this.level = level;
                this.rng = rng;
                // Initialization of the cells values
                for (int i = 0; i < 8; i++)
                    for (int j = 0; j < 8; j++)
                    {
                        cells[i, j] = new Cell();
                        cells[i, j].parent = new Coordinates();
                        if (IsAWall(i, j))
                            cells[i, j].cost = 100;
                        else
                            cells[i, j].cost = 1;
                    }

                // Adding the start cell on the list opened
                opened.Add(startCell);

                // Boolean value which indicates if a path is found
                Boolean pathFound = false;

                // Loop until the list opened is empty or a path is found
                do
                {
                    List<Coordinates> neighbors = new List<Coordinates>();
                    // The next cell analyzed
                    Coordinates currentCell = ShorterExpectedPath();
                    // The list of cells reachable from the actual one
                    neighbors = neighborsCells(currentCell);
                    foreach (Coordinates newCell in neighbors)
                    {
                        // If the cell considered is the final one
                        if (newCell.row == finishCell.row && newCell.col == finishCell.col)
                        {
                            cells[newCell.row, newCell.col].g = cells[currentCell.row,
                                currentCell.col].g + cells[newCell.row, newCell.col].cost;
                            cells[newCell.row, newCell.col].parent.row = currentCell.row;
                            cells[newCell.row, newCell.col].parent.col = currentCell.col;
                            pathFound = true;
                            break;
                        }

                        // If the cell considered is not between the open and closed ones
                        else if (!opened.Contains(newCell) && !closed.Contains(newCell))
                        {
                            cells[newCell.row, newCell.col].g = cells[currentCell.row,
                                currentCell.col].g + cells[newCell.row, newCell.col].cost;
                            cells[newCell.row, newCell.col].f =
                                cells[newCell.row, newCell.col].g + Heuristic(newCell);
                            cells[newCell.row, newCell.col].parent.row = currentCell.row;
                            cells[newCell.row, newCell.col].parent.col = currentCell.col;
                            SetCell(newCell, opened);
                        }

                        // If the cost to reach the considered cell from the actual one is
                        // smaller than the previous one
                        else if (cells[newCell.row, newCell.col].g > cells[currentCell.row,
                            currentCell.col].g + cells[newCell.row, newCell.col].cost)
                        {
                            cells[newCell.row, newCell.col].g = cells[currentCell.row,
                                currentCell.col].g + cells[newCell.row, newCell.col].cost;
                            cells[newCell.row, newCell.col].f =
                                cells[newCell.row, newCell.col].g + Heuristic(newCell);
                            cells[newCell.row, newCell.col].parent.row = currentCell.row;
                            cells[newCell.row, newCell.col].parent.col = currentCell.col;
                            SetCell(newCell, opened);
                            ResetCell(newCell, closed);
                        }
                    }
                    SetCell(currentCell, closed);
                    ResetCell(currentCell, opened);
                } while (opened.Count > 0 && pathFound == false);

                if (pathFound)
                {
                    path.Add(finishCell);
                    Coordinates currentCell = new Coordinates(finishCell.row, finishCell.col);
                    // It reconstructs the path starting from the end
                    while (cells[currentCell.row, currentCell.col].parent.row >= 0)
                    {
                        path.Add(cells[currentCell.row, currentCell.col].parent);
                        int tmp_row = cells[currentCell.row, currentCell.col].parent.row;
                        currentCell.col = cells[currentCell.row, currentCell.col].parent.col;
                        currentCell.row = tmp_row;
                    }
                }
            }

            // It select the cell between those in the list opened that have the smaller
            // value of f
            public Coordinates ShorterExpectedPath()
            {
                int sep = 0;
                if (opened.Count > 1)
                {
                    for (int i = 1; i < opened.Count; i++)
                    {
                        if (cells[opened[i].row, opened[i].col].f < cells[opened[sep].row,
                            opened[sep].col].f)
                        {
                            sep = i;
                        }
                    }
                }
                return opened[sep];
            }

            // It finds che cells that could be reached from c
            public List<Coordinates> neighborsCells(Coordinates c)
            {
                List<Coordinates> lc = new List<Coordinates>();
                for (int i = -1; i <= 1; i++)
                    for (int j = -1; j <= 1; j++)
                        if (c.row + i >= 0 && c.row + i < 8 && c.col + j >= 0 && c.col + j < 8 &&
                            (i != 0 || j != 0))
                        {
                            lc.Add(new Coordinates(c.row + i, c.col + j));
                        }
                return lc;
            }
            public int[,] walls(int level, int rng)
            {
                int[,] walls;
                ////easy
                if (level == 1)
                {
                    if (rng == 1)
                    {
                        walls = new int[,] { { 1, 1 }, { 2, 1 }, { 3, 1 }, { 5, 1 },
                        { 6, 1 }, { 7, 1 }, { 3, 2 }, { 3, 3 }, { 3, 4 }, { 3, 5 },
                        { 5, 3 }, {5, 4 }, {5, 5 }, {0, 3}, {1, 3 }, {4, 5 } };
                        return walls;
                    }
                    else if (rng == 2)
                    {
                        walls = new int[,]  { {1, 1}, { 2, 1 }, { 3, 1 }, { 4, 1 },
                            { 5, 1 }, { 6, 1 }, {1, 2 }, { 1, 3 }, { 1, 4 }, { 1, 5 },
                            { 1, 6 }, { 2, 6 }, { 3, 6 }, { 4, 6 }, { 5, 6 }, { 6, 6 },
                            {6, 2 }, { 6, 3 }, { 6, 4 }, { 6, 5 }, { 6, 6 }, };
                        return walls;
                    }
                    else if (rng == 3)
                    {
                        walls = new int[,] { { 1, 1 }, { 2, 1 }, { 3, 1 }, { 4, 1 },
                            { 5, 1 }, { 6, 1 }, { 7, 1 }, { 3, 2 }, { 3, 3 }, { 3, 4 },
                            { 3, 5 }, { 5, 3 }, {5, 4 }, {5, 5 }, {6, 5 }, {0, 3}, {3, 7 } };
                        return walls;
                    }
                }
                //medium
                if (level == 2)
                {
                    if (rng == 1)
                    {
                        walls = new int[,] { { 0, 6 }, { 1, 6 }, { 1, 4 },
                            { 1, 3 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 3, 5 },
                            { 3,4 }, { 3, 2 }, { 3, 1 }, { 4, 6 }, {4, 4 },
                            {4, 2 }, { 5, 6 }, { 5, 4 }, {5, 3 }, {5, 2 }, {3, 0} };
                        return walls;
                    }
                    else if (rng == 2)
                    {
                        walls = new int[,] { { 1, 5 },{ 1, 3 }, { 1, 2 }, { 1, 1 },
                            { 1, 7 }, { 2, 1 }, { 3, 1 }, { 3, 1 }, { 3, 3 },
                            { 3, 4 }, { 3, 5 }, { 4, 1 }, { 4,  1}, { 4, 3 }, { 4, 5 },
                            { 5, 1}, { 5, 1 }, { 5,  3}, { 5, 5 }, { 5, 2 } , { 6, 5 },
                            { 6, 1 }, { 1, 6 }, { 3, 6 }, { 7, 1 }, { 7, 5 }};
                        return walls;
                    }
                    else if (rng == 3)
                    {
                        walls = new int[,] { { 0, 5 },  { 1, 1 },{ 1, 3 }, { 1, 4 }, { 1, 5 },
                            { 2, 1 }, { 2, 5 }, { 3, 1 }, { 3, 2 }, { 3, 3 }, { 3, 5 }, { 4, 3 },
                            { 4, 5 }, { 5, 1 },{ 5, 2 } , { 5, 3 }, { 5, 5 }, { 6, 1 }, 
                            { 6, 3 }, { 6, 5 }, { 6, 0 }};
                        return walls;
                    }
                }
                //hard
                if (level == 3)
                {
                    if (rng == 1)
                    {
                        walls = new int[,] {{ 6, 1 },{ 1, 2 },{ 1, 0 }, { 1, 1 },
                            { 1, 4 }, { 1, 5 }, { 1, 6 },{ 3, 1 }, { 2, 4 }, { 3, 2 },
                            { 3, 3 }, { 3, 4 }, { 3, 5 }, {4, 1 } , {5, 1 },{ 5, 3 },
                            { 5, 4 }, { 5, 5 }, { 5, 6 }, {5, 7 } };
                        return walls;
                    }
                    else if (rng == 2)
                    {
                        walls = new int[,] { { 6, 1 },{ 1, 1 }, { 1, 3 }, { 1, 4 },
                            { 1, 5 }, { 1, 6 }, { 2, 1 }, { 2, 3 }, { 3,1  }, { 3, 3 },
                            { 3, 5 }, { 4, 1 }, { 4, 5 }, { 5, 1 }, { 5, 2 }, { 5, 3 },
                            { 5, 4 }, { 5, 5 }, { 6, 5 },{ 7, 5 }, {5, 7} };
                        return walls;
                    }
                    else if (rng == 3)
                    {
                        walls = new int[,] { { 0, 3 },{ 1, 1 }, { 1, 3 }, { 2, 5 },
                            { 1, 5 }, { 2, 1 }, { 3, 2 }, { 3,1  }, { 3, 3 }, { 3, 5 },
                            { 3, 4 }, { 4, 3 }, { 5, 0 }, { 5, 1 }, { 5, 3 }, { 5, 5 },
                            { 5,6 },{ 6, 3 } ,{ 7, 3 }, {5, 7 } };
                        return walls;
                    }
                }
                return null;
            }
            // It determines if the cell with coordinates (row, col) is a wall
            public bool IsAWall(int row, int col)
            {
                bool found = false;
                for (int i = 0; i < walls(level, rng).GetLength(0); i++)
                    if (walls(level, rng)[i, 0] == row && walls(level, rng)[i, 1] == col)
                        found = true;
                return found;
            }

            // The function Heuristic, which determines the shortest path that a 'king' can do
            // This is the maximum value between the orizzontal distance and the vertical one
            public int Heuristic(Coordinates cell)
            {
                int dRow = Math.Abs(finishCell.row - cell.row);
                int dCol = Math.Abs(finishCell.col - cell.col);
                return Math.Max(dRow, dCol);
            }

            // It inserts the coordinates of cell in a list, if it's not already present
            public void SetCell(Coordinates cell, List<Coordinates> coordinatesList)
            {
                if (coordinatesList.Contains(cell) == false)
                {
                    coordinatesList.Add(cell);
                }
            }

            // It removes the coordinates of cell from a list, if it's already present
            public void ResetCell(Coordinates cell, List<Coordinates> coordinatesList)
            {
                if (coordinatesList.Contains(cell))
                {
                    coordinatesList.Remove(cell);
                }
            }
        }
    }
}
