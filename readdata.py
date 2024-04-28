import numpy as np
import nrrd

filename = 'CTA-cardio.nrrd'

# Read the data back from file
readdata, header = nrrd.read(filename)
print(readdata.shape)
print(header)

# print(readdata[200][200])

out_file = open('output.txt', 'w')
out_file.write(str(readdata.shape[0]) + '\n')
out_file.write(str(readdata.shape[1]) + '\n')
out_file.write(str(readdata.shape[2]) + '\n')

out_file.write('\n')

for x in range(readdata.shape[0]):
    for y in range(readdata.shape[1]):
        for z in range(readdata.shape[2]):
            out_file.write(str(readdata[x][y][z]))
            if (z != readdata.shape[2] - 1 or y != readdata.shape[1] - 1):
                out_file.write(',')
            else:
                out_file.write('\n')

out_file.close()
