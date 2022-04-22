T = int(input())

for i in range(T):
    radii = input().split()

    R1 = int(radii[0])
    R2 = int(radii[1])
    Total_radius = (R1 * 2 + R2 * 2) / 2
    print(int(Total_radius))