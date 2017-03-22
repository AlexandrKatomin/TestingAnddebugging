using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_lab_2 {
   public static  class Sort {
        /*
        public static int[] SortByChoice(int[] array) {
            for (int i = 0; i < array.Length; i++) {
                int iMin = i;
                for (int j = 0; j < array.Length; j++) {
                    if (array[j] < array[i]) {
                        iMin = j;
                    }
                }
                if (iMin != i) {
                    int tmp = array[i];
                    array[i] = array[iMin];
                    array[iMin] = tmp;
                }
            }
            return array;
        }
        */
        
        public static List<int> SortByChoice(List<int> array) {
            for (int i = 0; i < array.Count-1; i++) {
                int iMin = i;
                for (int j = i+1; j < array.Count; j++) {
                    if (array[j] < array[iMin]) {
                        iMin = j;
                    }
                }
                if (iMin != i) {
                    int tmp = array[i];
                    array[i] = array[iMin];
                    array[iMin] = tmp;
                }
            }
            
            return array;
        }
    }
}
