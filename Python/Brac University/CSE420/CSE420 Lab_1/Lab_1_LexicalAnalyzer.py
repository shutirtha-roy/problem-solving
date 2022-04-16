class Lab_1_LexicalAnalyzer:    #18301028 Shutirtha Roy

    def __init__(self):

        self.keywords = []
        self.identifiers = set()
        self.math_operator = set()
        self.logical_operator = set()
        self.numerical_values = []
        self.others = set()


    def fileReader(self: object, file_input: str, mode: str):

        with open(file_input, mode) as file:

            lines = file.readlines()

            return self.file_inputAdder(lines)


    def file_inputAdder(self: object, lines: list):

        lines_popper = [rows.replace('\n', '') for rows in lines]

        return lines_popper


    def lexical_analysis(self: object, input_file: list):

        for rows in input_file:

            for splitted in  rows.split(' '):

                if 'int' == splitted or 'float' == splitted or \
                'if' == splitted or 'else' == splitted:
                    self.keywords.append(splitted)
                    continue

                if '+' == splitted or '-' == splitted or \
                '=' == splitted:
                    self.math_operator.add(splitted)
                    continue

                if '<' == splitted or '>' == splitted:
                    self.logical_operator.add(splitted)
                    continue

                if '(' == splitted or ')' == splitted or \
                    '{' == splitted or '}' == splitted:
                    self.others.add(splitted)
                    continue

                self.numerical_identifier_other_Splitter(splitted, self.numerical_values,
                                          self.identifiers, self.others)

        self.printDetails(self.keywords, self.identifiers, self.math_operator,
                          self.logical_operator, self.numerical_values, self.others)


    def numerical_identifier_other_Splitter(self: object, splitted: list, numerical_values: list,
                                            identifiers: list, others: list):

        if len(splitted) != 0 and splitted[0].isdigit():

            if splitted.find(';') != -1: #if splitted.find = -1, then symbol not found
                self.numerical_values.append(splitted[0:-1])
                self.others.add(';')
            elif splitted.find(',') != -1:
                self.numerical_values.append(splitted[0:-1])
                self.others.add(',')
            else:
                self.numerical_values.append(splitted[0:-1])

        elif len(splitted) != 0 and splitted[0].isalpha():

            if splitted.find(';') != -1:
                self.identifiers.add(splitted[0:-1])
                self.others.add(';')
            elif splitted.find(',') != -1:
                self.identifiers.add(splitted[0:-1])
                self.others.add(',')
            else:
                self.identifiers.add(splitted[0:-1])


    def printDetails(self, keywords: list, identifiers: list, math_operator: list,
                    logical_operator: list, numerical_values: list, others: list):

        print("Keywords:" , ', '.join(keywords))
        print("Identifiers:" , ', '.join(sorted(identifiers)))
        print("Math Operators" , ', '.join(sorted(math_operator)))
        print("Logical Operators" , ', '.join(sorted(list(logical_operator))))
        print("Numerical Values:" , ', '.join(numerical_values))
        print("Others: ", ' '.join(sorted(list(sorted(others)))))


if __name__ == "__main__":
    token = Lab_1_LexicalAnalyzer()
    input_file = token.fileReader('input.txt', 'r') #Takes input file as array
    token.lexical_analysis(input_file)
