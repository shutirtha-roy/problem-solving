class Solution {
    private int processOperation(String operation) {
        var firstIndex = 0;
        var operationLastIndex = operation.length() - 1;

        if (isDecrement(operation, firstIndex, operationLastIndex)) {
            return -1;
        }

        if (isIncrement(operation, firstIndex, operationLastIndex)) {
            return 1;
        }

        return 0;
    }

    private boolean isIncrement(String operation, int firstIndex, int lastIndex) {
        return operation.charAt(firstIndex) == '+' 
            || operation.charAt(lastIndex) == '+';
    }

    private boolean isDecrement(String operation, int firstIndex, int lastIndex) {
        return operation.charAt(firstIndex) == '-' 
            || operation.charAt(lastIndex) == '-';
    }

    public int finalValueAfterOperations(String[] operations) {
        var operationLength = operations.length;
        var finalCount = 0;
        
        for (var operation: operations) {
            finalCount += processOperation(operation);
        }

        return finalCount;
    }
}