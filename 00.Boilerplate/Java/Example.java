import java.io.*;
import java.lang.NumberFormatException;

public class Example {
    public static int[][] readFromStdIn() throws IOException {
        BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
        String s;

        //Store length of data
        s = in.readLine();
        int i, j = 0, numbers[][];
        i = Integer.parseInt(s);
        numbers = new int[i][3];

        while ((s = in.readLine()) != null && s.length() != 0) {
            String[] intString = s.split(" ");
            for(int k=0; k<intString.length; k++) {
                numbers[j][k] = Integer.parseInt(intString[k]);
            }
            j++;
        }

        return numbers;
    }

    public static int gcd(int i, int j) {
        if (j == 0) return i;
        int k = i % j;
        return gcd(j, k);
    }

    public static void main(String[] args) {
        try {
            int[][] numbers = readFromStdIn();

            for(int x = 0; x < numbers.length; x++) {
                int euclid = gcd(numbers[x][0], numbers[x][1]);
                if(euclid == numbers[x][2])
                    System.out.println("OK");
                else
                    System.out.println(euclid);

            }
        }
        catch (IOException e) {
            e.printStackTrace();
        }
    }
}
