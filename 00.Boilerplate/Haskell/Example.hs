module Main where

import Prelude hiding (gcd)
import System.IO

gcd :: Int -> Int -> Int
gcd i j
  | j == 0 = i
  | otherwise = gcd j k
  where k = i `mod` j

main = do file <- getContents
          putStr file
