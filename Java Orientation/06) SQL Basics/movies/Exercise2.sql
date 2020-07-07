SELECT DISTINCT year FROM movie
JOIN rating ON movie.mID = rating.mID
WHERE stars >3 
ORDER BY year ASC;