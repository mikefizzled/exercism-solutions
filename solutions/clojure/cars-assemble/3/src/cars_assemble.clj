(ns cars-assemble)


(def linear-rate 221)

(defn production-success [speed]
  (cond 
      (= speed 0) 0
      (<= speed 4) 1
      (<= speed 8) 0.9
      (= speed 9) 0.8
      (= speed 10) 0.77
  ))

(defn production-rate [speed](* (production-success speed) speed linear-rate))

(defn working-items [speed] 
  (int (/(production-rate speed) 60)))
