module Main where

import System.IO
import Data.List.Split (splitOn)
import Prelude hiding (gcd)

gcd :: Int -> Int -> Int
gcd i j
  | j == 0 = i
  | otherwise = gcd j k
  where k = i `mod` j

gcdChecker [a, b, c]
  | g == (read c :: Int) = "OK"
  | otherwise = show g
    where g = gcd (read a :: Int) (read b :: Int)

gcdHelper :: [String] -> [String]
gcdHelper [] = []
gcdHelper (x:xs) = gcdChecker (splitOn " " x) : gcdHelper xs


getInputCount :: IO Int
getInputCount = readLn

main :: IO ()
main = do
  lineCount <- getInputCount
  lines <- fmap (take lineCount . lines) getContents
  mapM_ putStrLn (gcdHelper lines)
