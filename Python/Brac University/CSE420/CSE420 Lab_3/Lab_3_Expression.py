import re #18301028 Shutirtha Roy Lab -3

class Lab_3_Expression:

    def __init__(self):
        self.regex_list = list()


    def regexCapture(self, num: int):

        for i in range(0, num, 1):
            regex_int = input()
            self.regex_list.append(regex_int)

        no_of_string = int(input())
        self.stringCapture(no_of_string)


    def stringCapture(self, no_of_string: int):

        for strings in range(0, no_of_string, 1):
            count = 0
            string_value = input()

            for pos, expressions in enumerate(self.regex_list):
                if type(re.search(expressions, string_value)) == re.Match:
                    count = pos + 1

            if count == 0:
                print('NO,', count)
            else:
                print('YES,', count)


if __name__ == "__main__":
    regexExpress = Lab_3_Expression()

    num_One = int(input())
    regexExpress.regexCapture(num_One)