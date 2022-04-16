import re


class Lab_4_LexicalAnalyzer:    #18301028 Shutirtha Roy

    def __init__(self: object):

        self.method = list()

        self.return_Value = list()


    def fileReader(self: object, file_input: str, mode: str):

        with open(file_input, mode) as file:

            lines = file.readlines()

            return self.file_inputAdder(lines)


    def file_inputAdder(self: object, lines: list):

        lines_popper = [rows.replace('\n', '') for rows in lines]

        return lines_popper


    def lexical_analysis(self: object, lines: list):

        for sentences in lines:

            if sentences.startswith('public'):

                if sentences.split(' ')[1] == 'class' or type(re.search(r"main", sentences)) == re.Match:
                    continue
                else:
                    if sentences.split(' ')[1] == 'static':
                        self.return_Value.append(sentences.split(' ')[2])
                        self.method.append(re.findall(str(sentences.split(' ')[2]) + '\s(.*)',sentences))
                    else:
                        self.return_Value.append(sentences.split(' ')[1])
                        self.method.append(re.findall(str(sentences.split(' ')[1]) + '\s(.*)',sentences))


    def printDetails(self: object):

        print("Methods:")

        for i in range(len(self.method)):

            print(f'{self.method[i][0]}, return type: {self.return_Value[i]}')



if __name__ == "__main__":

    token = Lab_4_LexicalAnalyzer()

    input_file = token.fileReader('input.txt', 'r') #Takes input file as array

    token.lexical_analysis(input_file)

    token.printDetails()
