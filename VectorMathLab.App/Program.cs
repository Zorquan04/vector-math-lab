using VectorMathLab.Implementation;

namespace VectorMathLab.App
{
    internal static class Program
    {
        static void Main()
        {
            // Tworzymy trzy przykładowe wektory 2D
            var v1 = new Vector2D(3, 4);
            var v2 = new Vector2D(1, -2);
            var v3 = new Vector2D(-4, 1);

            var vectors = new[] { v1, v2, v3 };

            Console.WriteLine("=== Układ kartezjański ===");
            foreach (var v in vectors)
                Console.WriteLine($"{v}: |v| = {v.Abs():F2}");

            Console.WriteLine("\n=== Układ biegunowy ===");
            foreach (var v in vectors)
            {
                var polar = new Polar2DAdapter(v);
                Console.WriteLine($"{v} -> {polar}");
            }

            Console.WriteLine("\n=== Iloczyny skalarne ===");
            for (int i = 0; i < vectors.Length; i++)
            for (int j = i + 1; j < vectors.Length; j++)
                Console.WriteLine($"v{i+1}·v{j+1} = {vectors[i].Cdot(vectors[j]):F2}");

            Console.WriteLine("\n=== Iloczyny wektorowe (w 3D) ===");
            var v3D1 = new Vector3DDecorator(v1, 0);
            var v3D2 = new Vector3DDecorator(v2, 0);
            var v3D3 = new Vector3DDecorator(v3, 0);

            var arr3D = new[] { v3D1, v3D2, v3D3 };
            for (int i = 0; i < arr3D.Length; i++)
            for (int j = i + 1; j < arr3D.Length; j++)
                Console.WriteLine($"v{i+1} x v{j+1} = {arr3D[i].Cross(arr3D[j])}");
            
            Console.WriteLine("\n=== Program zakończył działanie pomyślnie ===");
        }
    }
}