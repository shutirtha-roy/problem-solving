class Lab_2_Valid_Expression:     #18301028 Shutirtha Roy Lab - 2


    def passing_values_of_inputs(self: object, no_on_inputs: int):

        for index, values in enumerate(range(0, no_on_inputs, 1)):
            value = input()
            print(self.checker(value, index + 1))


    def checker(self: object, value: str, position: int):

        if value.count('@') == 1 and value.endswith('.com') and \
                                        value[0].isalpha():
            return self.email_address(value, position)

        elif value.startswith('www.') and value.count('.') == 2:
            return self.web_address(value, position)

        else:
            if value.startswith('www.'):
                return 'Invalid Web Address'
            elif value.count('@') == 1:
                return 'Invalid Email'
                checker = 0
            else:
                return 'Invalid  Web Address or Email'


    def email_address(self: object, value: str,  position: int):

        left_splitted, right_splitted = value.split('@')

        for val in left_splitted[1:]:
            if not (val.isalpha() or val.isnumeric() or val == '.'):
                return 'Invalid Email'

        for val in right_splitted[:-4]:
            if not val.isalpha():
                return 'Invalid Email'

        domain_splitted =  right_splitted[:-4]

        if domain_splitted in ['gmail', 'yahoo', 'aol', 'outlook', 'zoho', 'iCloud'] and \
                              right_splitted.count('.') == 1:
            return f"Email, {position}"


    def web_address(self: object, value: str, position: int):
        left, mid, right = value.split('.')

        if len(mid) <= 0 or len(mid) > 63:
            return 'Invalid Web Address'

        for val in mid:
            if not (val.isalpha() or val.isnumeric() or val == '-'):
                return 'Invalid Web Address'

        if right in ['com', 'gov', 'org', 'net', 'biz', 'info', 'co', 'us', 'xyz']:
            return f"Web, {position}"


if __name__ == '__main__':

    expression_valued = Lab_2_Valid_Expression()

    no_on_inputs = int(input())
    expression_valued.passing_values_of_inputs(no_on_inputs)
