class Solution:
    def maxArea(self, h: int, w: int, hc: List[int], vc: List[int]) -> int:
        hc.append(0)
        hc.append(h)
        vc.append(0)
        vc.append(w)
        hc.sort()
        vc.sort()
        a,b=0,0
        for i in range(0,len(hc)):
            a=max(a,hc[i]-hc[i-1])
        for j in range(0,len(vc)):
            b=max(b,vc[j]-vc[j-1])
        return (a*b)%(10**9+7)
            
