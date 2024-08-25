# HelicopterProject
---

# 도라에몽(Player)
---
![image](https://github.com/SeungJu0406/HelicopterProject/blob/main/README_Image/%EB%8F%84%EB%9D%BC%EC%97%90%EB%AA%BD.png?raw=true)

- 게임의 플레이어
- 키 조작
	- w: 전진
	- s: 후진
	- a,d: 좌 우 회전
	- space: 프로펠러 회전
	- 0 : 미사일 발사


# 이동
---
![image](https://github.com/SeungJu0406/HelicopterProject/blob/main/README_Image/%EC%9D%B4%EB%8F%99.gif?raw=true)
- 전진, 후진 가능
- a, d 입력을 통해 플레이어의 회전이 가능함

# 비행
---
![image](https://github.com/SeungJu0406/HelicopterProject/blob/main/README_Image/%EB%B9%84%ED%96%89.gif?raw=true)
- space를 눌러 프로펠러 동작 가능
- 프로펠러 최대 속도 시, y값 최대 20까지 비행 가능
- 프로펠러 동작 시 연료가 점차 감소
- 프로펠러 정지 시 연료가 점차 차오름
- 연료가 있을 때만 비행이 가능

![image](https://github.com/SeungJu0406/HelicopterProject/blob/main/README_Image/%EC%97%B0%EB%A3%8C%EB%B6%80%EC%A1%B1%EC%9C%BC%EB%A1%9C%20%EC%9D%B8%ED%95%9C%20%EC%B6%94%EB%9D%BD.gif?raw=true)

- 연료 부족 시 그 자리에서 추락
- 이후 5초동안 프로펠러 동작이 불가능


# 미사일 발사
--- 
![image](https://github.com/SeungJu0406/HelicopterProject/blob/main/README_Image/%EB%AF%B8%EC%82%AC%EC%9D%BC%20%EB%B0%9C%EC%82%AC.gif?raw=true)

- 0키 입력시 전방으로 미사일 오브젝트 발사
- 미사일은 필드에 최대 4초간 존재
- 만약 필드에 3개 이상의 미사일 존재 시에 가장 먼저 발사된 미사일 삭제