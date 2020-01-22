using System;
using System.Collections.Generic;
using System.Text;

namespace FOCommon.Maps
{
    public interface LineTracerCallback
    {
        ushort Hx { get; }
        ushort Hy { get; }
        ushort Tx { get; }
        ushort Ty { get; }
        ushort MaxHx { get; }
        ushort MaxHy { get; }
        int Dist { get; }
        double Angle { get; }
        bool Exec(ushort hx, ushort hy);
    }

    public static class Const
    {
        public const double Sqrt3t2 = 3.46410162;
        public const double RadToDeg = 57.2957795;
        public const double Bias = 0.02;
        public const double Sqrt3 = 1.73205081;
    }

    public class LineTracer
    {
        ushort maxHx;
        ushort maxHy;
        double x1;
        double y1;
        double x2;
        double y2;
        double dir;
        byte  dir1;
        byte  dir2;
        double dx;
        double dy;

        public LineTracer(ushort hx, ushort hy, ushort tx, ushort ty, ushort maxhx, ushort maxhy, double angle, bool is_square)
        {
            maxHx = maxhx;
            maxHy = maxhy;

            if( is_square )
            {
                dir = Math.Atan2((double) ( ty - hy ), (double) ( tx - hx )) + angle;
                dx = Math.Cos(dir);
                dy = Math.Sin(dir);
                if( Math.Abs(dx) > Math.Abs(dy) )
                {
                    dy /= Math.Abs(dx);
                    dx = (dx > 0 ? 1.0f : -1.0f);
                }
                else
                {
                    dx /= Math.Abs(dy);
                    dy = (dy > 0 ? 1.0f : -1.0f);
                }
                x1 = (double) hx + 0.5f;
                y1 = (double) hy + 0.5f;
            }
            else
            {
                double nx = 3.0f * ((double)(tx) - (double)(hx));
                double ny = ((double)(ty) - (double)(hy)) * Const.Sqrt3t2 - ((double)(tx & 1) - (double)(hx & 1)) * Const.Sqrt3;
                this.dir = 180.0f + Const.RadToDeg * Math.Atan2(ny, nx);
                if( angle != 0.0f )
                {
                    this.dir += angle;
                    normalizeDir();
                }

                if( dir >= 30.0f && dir < 90.0f )
                {
                    dir1 = 5;
                    dir2 = 0;
                }
                else if( dir >= 90.0f && dir < 150.0f )
                {
                    dir1 = 4;
                    dir2 = 5;
                }
                else if( dir >= 150.0f && dir < 210.0f )
                {
                    dir1 = 3;
                    dir2 = 4;
                }
                else if( dir >= 210.0f && dir < 270.0f )
                {
                    dir1 = 2;
                    dir2 = 3;
                }
                else if( dir >= 270.0f && dir < 330.0f )
                {
                    dir1 = 1;
                    dir2 = 2;
                }
                else
                {
                    dir1 = 0;
                    dir2 = 1;
                }

                x1 = 3.0f * (double)(hx) + Const.Bias;
                y1 = Const.Sqrt3t2 * (double)(hy) - Const.Sqrt3 * ((double)(hx & 1)) + Const.Bias;
                x2 = 3.0f * (double)(tx) + Const.Bias + Const.Bias;
                y2 = Const.Sqrt3t2 * (double)(ty) - Const.Sqrt3 * ((double)(tx & 1)) + Const.Bias;
                if( angle != 0.0f )
                {
                    x2 -= x1;
                    y2 -= y1;
                    double xp = Math.Cos(angle / Const.RadToDeg) * x2 - Math.Sin(angle / Const.RadToDeg) * y2;
                    double yp = Math.Sin(angle / Const.RadToDeg) * x2 + Math.Cos(angle / Const.RadToDeg) * y2;
                    x2 = x1 + xp;
                    y2 = y1 + yp;
                }
                dx = x2 - x1;
                dy = y2 - y1;
            }
        }

        void normalizeDir()
        {
            if (dir <= 0.0f)
                dir = 360.0f - ((-dir) % 360.0f);
            else if (dir >= 0.0f)
                dir = dir % 360.0f;
        }

        public byte GetNextHex(ref ushort cx, ref ushort cy)
        {
            ushort t1x = cx;
            ushort t2x = cx;
            ushort t1y = cy;
            ushort t2y = cy;
            MoveHexByDir(ref t1x, ref t1y, dir1, maxHx, maxHy);
            MoveHexByDir(ref t2x, ref t2y, dir2, maxHx, maxHy);
            double dist1 = dx * (y1 - (Const.Sqrt3t2 * (double)(t1y) - ((double)(t1x & 1)) * Const.Sqrt3)) - dy * (x1 - 3 * (double)(t1x));
            double dist2 = dx * (y1 - (Const.Sqrt3t2 * (double)(t2y) - ((double)(t2x & 1)) * Const.Sqrt3)) - dy * (x1 - 3 * (double)(t2x));
            dist1 = (dist1 > 0 ? dist1 : -dist1);
            dist2 = (dist2 > 0 ? dist2 : -dist2);
            if(dist1 <= dist2) // Left hand biased
            {
                cx = t1x;
                cy = t1y;
                return dir1;
            }
            else
            {
                cx = t2x;
                cy = t2y;
                return dir2;
            }
        }

        public void GetNextSquare(ref ushort cx, ref ushort cy)
        {
            x1 += dx;
            y1 += dy;
            cx = (ushort) Math.Floor( x1 );
            cy = (ushort) Math.Floor(y1);
            if (cx >= maxHx)
                cx = (ushort)(maxHx - 1);
            if (cy >= maxHy)
                cy = (ushort)(maxHy - 1);
        }

        public static bool MoveHexByDir(ref ushort hx, ref ushort hy, byte dir, ushort maxhx, ushort maxhy)
        {
            ushort hx_ = hx;
            ushort hy_ = hy;

            switch (dir)
            {
                case 0:
                    hx_--;
                    if ((hx_ & 1) == 0)
                        hy_--;
                    break;
                case 1:
                    hx_--;
                    if ((hx_ & 1) != 0)
                        hy_++;
                    break;
                case 2:
                    hy_++;
                    break;
                case 3:
                    hx_++;
                    if ((hx_ & 1) != 0)
                        hy_++;
                    break;
                case 4:
                    hx_++;
                    if ((hx_ & 1) == 0)
                        hy_--;
                    break;
                case 5:
                    hy_--;
                    break;
                default:
                    break;
            }

            if( hx_ >= 0 && hx_ < maxhx && hy_ >= 0 && hy_ < maxhy )
            {
                hx = hx_;
                hy = hy_;
                return true;
            }
            return false;
        }

        public static int GetDistance(ushort x1, ushort y1, ushort x2, ushort y2)
        {
            int dx = (x1 > x2 ? x1 - x2 : x2 - x1);
            if ((x1 & 1) == 0)
            {
                if (y2 <= y1)
                {
                    int rx = y1 - y2 - dx / 2;
                    return dx + (rx > 0 ? rx : 0);
                }
                else
                {
                    int rx = y2 - y1 - (dx + 1) / 2;
                    return dx + (rx > 0 ? rx : 0);
                }
            }
            else
            {
                if (y2 >= y1)
                {
                    int rx = y2 - y1 - dx / 2;
                    return dx + (rx > 0 ? rx : 0);
                }
                else
                {
                    int rx = y1 - y2 - (dx + 1) / 2;
                    return dx + (rx > 0 ? rx : 0);
                }
            }
        }

        public static int TraceHex(LineTracerCallback callback)
        {
            ushort hx = callback.Hx;
            ushort hy = callback.Hy;
            int dist = callback.Dist == 0 ? GetDistance(hx, hy, callback.Tx, callback.Ty) : callback.Dist;
            if (dist == 0) dist = GetDistance(hx, hy, callback.Tx, callback.Ty);
            LineTracer lt = new LineTracer(hx, hy, callback.Tx, callback.Ty,
                                callback.MaxHx, callback.MaxHy, callback.Angle, false);
            for (int i = 0; i < dist; i++)
            {
                if (callback.Exec(hx, hy)) return i;
                lt.GetNextHex(ref hx, ref hy);
            }
            return dist;
        }
    }
}
