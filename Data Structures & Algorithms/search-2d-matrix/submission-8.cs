public class Solution {
        public bool SearchMatrix(int[][] matrix, int target)
        {

        if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0) return false;

            var row=matrix.Length;
            var col=matrix[0].Length;

            var top=0;
            var bottom=row-1;

            while(top<=bottom)
            {
                var mid=top+(bottom-top)/2;
                if(target>=matrix[mid][0] && target<=matrix[mid][col-1])
                {
                    // do the binary search at the row level.
                    return SearchInTheExpectedRow(matrix,target,mid);
                }
                else if(target>matrix[mid][col-1]){
                    top=mid+1;
                }
                else{
                    bottom=mid-1;
                }
            }
            return false;
        }

        public bool SearchInTheExpectedRow(int[][] matrix, int target, int expectedRow)
        {
            var left=0;
            var right=matrix[expectedRow].Length-1;
            while(left<=right){
                var mid=left+(right-left)/2;
                if(target==matrix[expectedRow][mid])
                {
                    return true;
                }
                else if(target>matrix[expectedRow][mid])
                {
                    left=mid+1;
                }
                else{
                    right=mid-1;
                }
            }
            return false;
        }
}