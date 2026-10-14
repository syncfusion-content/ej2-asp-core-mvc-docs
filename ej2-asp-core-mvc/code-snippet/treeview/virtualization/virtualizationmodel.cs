using System.Collections.Generic;

public class TreeViewVirtualization
{
    public int Id { get; set; }
    public int? PId { get; set; }
    public string Name { get; set; }
    public bool HasChild { get; set; }
    public bool Expanded { get; set; }

    public static List<TreeViewVirtualization> GetVirtualizationData()
    {
        List<TreeViewVirtualization> data = new List<TreeViewVirtualization>();

        for (int i = 1; i <= 50; i++)
        {
            data.Add(new TreeViewVirtualization
            {
                Id = i,
                Name = "Parent Node " + i,
                HasChild = true,
                Expanded = true
            });

            for (int j = 1; j <= 20; j++)
            {
                data.Add(new TreeViewVirtualization
                {
                    Id = (i * 1000) + j,
                    PId = i,
                    Name = "Child Node " + i + "-" + j
                });
            }
        }

        return data;
    }
}