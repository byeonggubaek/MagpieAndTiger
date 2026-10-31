# 까치와 호랑이 · Magpie & Tiger

한국 전통 민화 **호작도**에서 영감을 받은 웹 게임 데모입니다.

현재 저장소에는 두 가지가 들어 있습니다.

- `web-demo/`: 설치 없이 브라우저에서 실행할 수 있는 픽셀아트 데모
- `unity-project/`: Unity WebGL 프로젝트로 확장하기 위한 Unity 소스 구조와 C# 게임 로직

## 웹 데모 실행

`web-demo/index.html`을 브라우저에서 직접 열기보다 로컬 서버를 사용하는 것을 권장합니다.

```bash
cd web-demo
python3 -m http.server 8080
```

브라우저에서 <http://localhost:8080>을 엽니다.

### 조작

- 이동: `WASD` 또는 방향키
- 상호작용: `E` 또는 `Space`
- 목표: 마을에 흩어진 색 조각 3개를 모아 호랑이에게 가져가기

## Unity 프로젝트

1. Unity Hub에서 Unity 6 LTS를 설치합니다.
2. 설치 모듈에 `Web Build Support`를 포함합니다.
3. Unity Hub에서 `unity-project` 폴더를 엽니다.
4. `Assets/Scenes/MagpieAndTiger.unity`를 만든 뒤 `Assets/Scripts/MagpieAndTigerDemo.cs`를 빈 GameObject에 연결합니다.
5. Web 플랫폼으로 Build and Run을 실행합니다.

Unity가 설치되지 않은 환경에서도 게임 흐름을 확인할 수 있도록 `web-demo`를 함께 제공합니다.

## 데모 기획

플레이어는 민화 속 수습 화공이 되어 까치의 안내를 따라 색 조각을 찾습니다. 장난스러운 호랑이는 색 조각을 돌려주는 대신 플레이어에게 민화 속 상징을 관찰하게 합니다. 짧은 탐험과 상호작용을 통해 호작도의 해학적인 분위기와 색의 의미를 경험하는 것이 목표입니다.

## 라이선스 및 문화적 사용

이 데모는 전통 민화의 모티프에서 영감을 받은 창작 프로토타입입니다. 특정 박물관 소장 이미지나 현대 작가의 작품을 복제하지 않습니다. 실제 출시 전에는 참고 자료, 폰트, 사운드, 이미지의 권리와 출처를 별도로 검토해야 합니다.
