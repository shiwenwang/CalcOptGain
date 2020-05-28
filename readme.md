# CalcOptGain

## 前言
风机通过叶轮从风中捕获风能，并将其转化为叶轮的机械能，从而带动发电机转子转动发电。

风机从风中获取的机械功率可以用公式表示为：
$$P = 1/2mv^2Cp$$
其中，$m$ 是单位时间内通过叶轮平面的风的动能，$Cp$ 是风能向机械能转化的功率系数。假设叶轮半径是 $R$，主导风速为 $v$，则$m=\rho \pi vR^2$。所以机械功率等价于：
$$P = 1/2 \rho ACpv^3R^2  \space \space \space \space \space \space \space  (1)$$

对于风机的传动部件来说，机械功率又等于：
$$P = Tg \omega g  \space \space \space \space \space \space \space  (2)$$

其中，$Tg$ 是发电机扭矩，$\omega g$ 是发电机转速角速度。

现在引入叶尖速比 $\lambda$ 的概念：
> 叶尖线速度与风速的比值，$\lambda=\omega R/v  \space \space \space \space \space \space \space  (3)$
不同的叶尖速比$\lambda$对应了不同的功率系数$Cp$。

整合公式`(1),(2),(3)`，可得：
$$Tg=\rho AR^5Cp \omega^2/2*\lambda^3$$

引入最优增益 $Kopt$ 的概念，下面公式中功率系数是最优值，叶尖速比也与最优功率系数对应：
$$Kopt = \rho AR^5Cpmax/2*\lambda opt^3$$
则有：
$$Tg = Kopt \omega^2$$

## 本应用

本应用使用 `C#` 编写，主要计算上述 $Kopt$ 的值，软件界面如下：

<p align="center">
  <img src="/static/img/main.bmp"></img>
</p>



